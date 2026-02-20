using static System.Console;
//Declaração de variaveis
double bas, altura, area, perimetro, diagonal;
//Entrada de dados
Write("Digite a bas do retangulo:");
bas = double.Parse(ReadLine());
Write("Digite a altura do retangulo: ");
altura = double.Parse(ReadLine());
//Processamento de dados
area = bas * altura;
perimetro = 2 * (bas + altura);
diagonal = Math.Sqrt((bas * bas) + (altura * altura));
//Saida de dados
WriteLine($"A área do retangulo é de: {area}, o perímetro é de: {perimetro} e a diagonal é de: {diagonal}");