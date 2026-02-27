// o usuario vai digitar um valor de 1 a 7 e esse código é para mostrar o dia da semana correspondente ao número digitado pelo usuário

//Declaração de variaveis
using static System.Console;
double valor; 
// Entrada de dados 
Write("Digite um numero de 1 a 7");
valor = int.Parse(Console.ReadLine());
if (valor == 1)
{
    WriteLine("Domingo");
}
else if (valor == 2)
{
    WriteLine("Segunda-feira");
}
else if (valor == 3)
{
    WriteLine("Terça-feira");
}
else if (valor == 4)
{
    WriteLine("Quarta-feira");
}
else if (valor == 5)
{
    WriteLine("Quinta-feira");
}
else if (valor == 6)
{
    WriteLine("Sexta-feira");
}
else if (valor == 7)
{
    WriteLine("Sábado");
}
else
{
 WriteLine("Número fora do intervalo permitido");
 
}   