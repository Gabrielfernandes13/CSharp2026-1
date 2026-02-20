using static System.Console;   
//Declaração de variaveis
int idade, meses, dias;
//Entrada de dados
Write("Digite a quantidade de dias:");
dias = int.Parse(ReadLine());   
idade = dias / 365;
meses = dias / 30 / 30;
dias = dias / 365 % 30;
Write($"idade {idade}, meses {meses}, dias {dias}");
