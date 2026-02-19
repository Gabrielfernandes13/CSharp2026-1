//Entrada de dados
Console.WriteLine("Digite o seu nome: ");
string nome = Console.ReadLine(); //Entrada de dados
System.Console.WriteLine($"O valor digitado é de {nome}");
System.Console.WriteLine("Digite o 1º primeiro número: ");
double x = double.Parse(Console.ReadLine());
System.Console.WriteLine("Digite o 2º primeiro número: ");
double y = double.Parse(Console.ReadLine());
//Processamento de dados
double soma = x + y;
System.Console.WriteLine($"A soma dos números é de {soma}");