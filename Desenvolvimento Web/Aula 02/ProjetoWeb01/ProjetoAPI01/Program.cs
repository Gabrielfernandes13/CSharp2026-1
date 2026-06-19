using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;
using ProjetoAPI01.Classes.Repositorio;
using ProjetoAPI01.Classes.DTO;

var builder = WebApplication.CreateSlimBuilder(args);
var stringConexaoBancoAluno = builder.Configuration.GetConnectionString("Aluno")
    ?? throw new InvalidOperationException("A string de conexão 'Aluno' não foi encontrada no appsettings.json");

// Configurar serialização (source-gen)
builder.Services.ConfigureHttpJsonOptions(options =>
{
    options.SerializerOptions.TypeInfoResolverChain.Insert(0, AppJsonSerializerContext.Default);
});

// Registrar repositório
builder.Services.AddScoped(_ => new RepositorioUsuario(stringConexaoBancoAluno));

// OpenAPI (opcional)
builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

var gruposUsuarios = app.MapGroup("/api/usuarios");

// Login
gruposUsuarios.MapPost("/login", async Task<IResult> (
    [FromBody] LoginRequestDTO dadosLogin, RepositorioUsuario repositorioUsuario, CancellationToken cancellationToken) =>
{
    if (string.IsNullOrWhiteSpace(dadosLogin.Email) || string.IsNullOrWhiteSpace(dadosLogin.Senha))
    {
        return Results.BadRequest(new LoginResponseDTO { Sucesso = false, Mensagem = "E-mail e senha são obrigatórios." });
    }

    var usuario = await repositorioUsuario.BuscarPorEmaileSenha(dadosLogin.Email, dadosLogin.Senha, cancellationToken);
    if (usuario is null) return Results.Unauthorized();

    return Results.Ok(new LoginResponseDTO
    {
        Sucesso = true,
        Mensagem = "Login realizado com sucesso",
        Nome = usuario.Nome,
        Regra = usuario.Regra
    });
}).WithName("LoginUsuario");

// Listar todos (painel admin)
gruposUsuarios.MapGet("/", async (RepositorioUsuario repositorioUsuario, CancellationToken cancellationToken) =>
{
    var lista = await repositorioUsuario.ListarTodos(cancellationToken);
    return Results.Ok(lista);
}).WithName("ListarUsuarios");

// Obter por id
gruposUsuarios.MapGet("/{id:int}", async (int id, RepositorioUsuario repositorioUsuario, CancellationToken cancellationToken) =>
{
    var usuario = await repositorioUsuario.BuscarPorId(id, cancellationToken);
    if (usuario is null) return Results.NotFound();
    return Results.Ok(usuario);
}).WithName("ObterUsuario");

// Atualizar
gruposUsuarios.MapPut("/{id:int}", async (int id, [FromBody] AdminRequestDTO dto, RepositorioUsuario repositorioUsuario, CancellationToken cancellationToken) =>
{
    if (id != dto.Id) return Results.BadRequest();

    var usuario = new UsuarioDTO
    {
        Id = dto.Id,
        Nome = dto.Nome,
        // se UsuarioDTO tiver Email, inclua; caso contrário ajuste conforme sua DTO atual
        Regra = dto.Regra
    };

    // Se sua UsuarioDTO tem Email, copie dto.Email para usuario.Email acima

    var sucesso = await repositorioUsuario.AtualizarUsuario(usuario, cancellationToken);
    return sucesso ? Results.NoContent() : Results.NotFound();
}).WithName("AtualizarUsuario");

// Excluir
gruposUsuarios.MapDelete("/{id:int}", async (int id, RepositorioUsuario repositorioUsuario, CancellationToken cancellationToken) =>
{
    var sucesso = await repositorioUsuario.ExcluirUsuario(id, cancellationToken);
    return sucesso ? Results.NoContent() : Results.NotFound();
}).WithName("ExcluirUsuario");

app.Run();

[JsonSerializable(typeof(LoginRequestDTO))]
[JsonSerializable(typeof(LoginResponseDTO))]
[JsonSerializable(typeof(UsuarioDTO))]
[JsonSerializable(typeof(AdminRequestDTO))]
internal partial class AppJsonSerializerContext : JsonSerializerContext
{
}