using static System.Console;
using ImpostodeRenda.Entidades;
using System.Diagnostics.CodeAnalysis;

namespace ImpostodeRenda
{
class Program
    {
static void Main(string[] args)
    {
    List<Contribuintes> contribuintes = new List<Contribuintes>();
            Console.Write("Digite o número de contribuintes: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nContribuinte #{i}");
                Console.Write("Pessoa física ou jurídica (f/j)? ");
                char tipo = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Renda anual: ");
                double rendaAnual = double.Parse(Console.ReadLine());

                if ( (tipo=='f')
                {
                    
                }
            }