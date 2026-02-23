using System.Runtime.CompilerServices;
using static System.Console;    
//Declaração de variaveis
Write("Digite o preco: ");
double preco = double.Parse(ReadLine());
Write("Digite a quantidade do produto:");
int quantidade = int.Parse(ReadLine());
Write("Digite o dinheiro recebido: ");
double dinheiro = double.Parse(ReadLine());
double troco = dinheiro - (preco * quantidade);
Console.WriteLine($"Troco: {troco}");

