using Figuras.Classes.Entidades;
using Figuras.Classes.Enumeracoes;
using static System.Console;

List<Forma> formas = new();

Write ("Entre com a quantidade de formas: ");
int qtd = int.Parse(ReadLine());

for (int i = 0; i < qtd; i++)
{
    WriteLine("Dados do objeto geometrico nº {i+1}:");
    Write($"Retângulo ou Círculo (r/c): ");
    char escolha = char.Parse(ReadLine().ToLower());
    if (escolha == 'r')
    {
        WriteLine("Qual é a Cor do objeto?" +
            "\n\t1 - Vermelho" +
            "\n\t2 - Azul" +
            "n\t3 - Amarelo" +
            "\n\t4 - Rosa");
        int cor = int.Parse(ReadLine());
        WriteLine("Digite a Largura do Retângulo: ");
        double l = double.Parse(ReadLine());
        Write("Digite a Altura do Retângulo: ");
        double a = double.Parse(ReadLine());
        formas.Add(new Retangulo((Cor)cor, l, a));
    }
    else if (escolha == 'c')
    {
        WriteLine("Qual é a Cor do objeto?" +
         "\n\t1 - Vermelho" +
         "\n\t2 - Azul" +
         "n\t3 - Amarelo" +
         "\n\t4 - Rosa");
        Write ("Digite o Raio da circunferencia: ");
        int cor = int.Parse(ReadLine());
        double r = double.Parse(ReadLine());
        formas.Add(new Circulo((Cor)cor, r));
    }
}
foreach (var figurinhas in formas)
{
    Write(figurinhas.ToString());
}