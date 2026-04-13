using ImpostodeRenda.Entidades;
using System.Collections.Generic;
using static System.Console;

List<Contribuintes> lista = new List<Contribuintes>();

Console.Write("Digite o número de contribuintes: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"\nContribuinte {i}:");
    Console.Write("Pessoa física ou jurídica (f/j)? ");
    char tipo = char.Parse(Console.ReadLine());

    Console.Write("Nome: ");
    string nome = Console.ReadLine();

    Console.Write("Renda anual: ");
    double renda = double.Parse(Console.ReadLine());

    if (tipo == 'f')
    {
        Console.Write("Gastos com saúde: ");
        double gastos = double.Parse(Console.ReadLine());

        lista.Add(Pf (nome, renda, gastos));
    }
    else
    {
        Console.Write("Número de funcionários: ");
        int funcionarios = int.Parse(Console.ReadLine());

        lista.Add(new Pj(nome, renda, funcionarios));
    }
}

Contribuintes Pf(string? nome, double renda, double gastos)
{
    throw new NotImplementedException();
}

Console.WriteLine("\nIMPOSTOS PAGOS:");
double total = 0;

foreach (Contribuintes c in lista)
{
    double imposto = c.Imposto();
    Console.WriteLine($"{c.Nome}: R$ {imposto:F2}");
    total += imposto;
}

Console.WriteLine($"\nTOTAL DE IMPOSTO: R$ {total:F2}");
