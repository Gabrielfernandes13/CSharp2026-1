using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using ProjetoAPI01.Classes.DTO;

namespace ProjetoAPI01.Classes.Repositorio
{
    public class RepositorioUsuario2
    {
        private readonly string stringConexao;

        public RepositorioUsuario2(string conexao)
        {
            this.stringConexao = conexao;
        }

        public async Task<List<UsuarioDTO>> ListarTodos(CancellationToken cancellationToken)
        {
            var lista = new List<UsuarioDTO>();
            await using var conexao = new SqlConnection(stringConexao);
            await conexao.OpenAsync(cancellationToken);

            const string sql = @"SELECT Id, Nome, Email, Regra FROM Alunos ORDER BY Nome";
            await using var comando = new SqlCommand(sql, conexao);
            await using var leitor = await comando.ExecuteReaderAsync(cancellationToken);
            while (await leitor.ReadAsync(cancellationToken))
            {
                lista.Add(new UsuarioDTO
                {
                    Id = leitor.GetInt32(leitor.GetOrdinal("Id")),
                    Nome = leitor.GetString(leitor.GetOrdinal("Nome")),
                    Email = leitor.GetString(leitor.GetOrdinal("Email")),
                    Regra = leitor.GetInt32(leitor.GetOrdinal("Regra"))
                });
            }
            return lista;
        }

        public async Task<UsuarioDTO?> BuscarPorId(int id, CancellationToken cancellationToken)
        {
            await using var conexao = new SqlConnection(stringConexao);
            await conexao.OpenAsync(cancellationToken);

            const string sql = @"SELECT Id, Nome, Email, Regra FROM Alunos WHERE Id = @id";
            await using var comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@id", id);

            await using var leitor = await comando.ExecuteReaderAsync(cancellationToken);
            if (!await leitor.ReadAsync(cancellationToken)) return null;

            return new UsuarioDTO
            {
                Id = leitor.GetInt32(leitor.GetOrdinal("Id")),
                Nome = leitor.GetString(leitor.GetOrdinal("Nome")),
                Email = leitor.GetString(leitor.GetOrdinal("Email")),
                Regra = leitor.GetInt32(leitor.GetOrdinal("Regra"))
            };
        }

        public async Task<bool> AtualizarUsuario(UsuarioDTO usuario, CancellationToken cancellationToken)
        {
            await using var conexao = new SqlConnection(stringConexao);
            await conexao.OpenAsync(cancellationToken);

            const string sql = @"UPDATE Alunos SET Nome = @nome, Email = @email, Regra = @regra WHERE Id = @id";
            await using var comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@nome", usuario.Nome);
            comando.Parameters.AddWithValue("@email", usuario.Email);
            comando.Parameters.AddWithValue("@regra", usuario.Regra);
            comando.Parameters.AddWithValue("@id", usuario.Id);

            var linhas = await comando.ExecuteNonQueryAsync(cancellationToken);
            return linhas > 0;
        }

        public async Task<bool> ExcluirUsuario(int id, CancellationToken cancellationToken)
        {
            await using var conexao = new SqlConnection(stringConexao);
            await conexao.OpenAsync(cancellationToken);

            const string sql = @"DELETE FROM Alunos WHERE Id = @id";
            await using var comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@id", id);

            var linhas = await comando.ExecuteNonQueryAsync(cancellationToken);
            return linhas > 0;
        }
    }
}