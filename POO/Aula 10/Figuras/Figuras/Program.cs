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

    }
}