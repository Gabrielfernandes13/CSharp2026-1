using static System.Console;
//Declaração de variaveis
double a, b, c, areat, p, areaT; 
bool triangulo;
//Entrada de dados
Write("Digite o valor de a: "); 
a = double.Parse(ReadLine());
Write("Digite o valor de b:");  
b = double.Parse(ReadLine());
Write("Digite o valor de c: ");
c = double.Parse(ReadLine());
//Processamento de dados
triangulo = (a+b)>c & (a+c)>b & (b+c)>a; 

if (triangulo == true)

{ 
    p = (a+b+c)/2;
    areat = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
WriteLine ($"area traingulo é:{areat}");
}
else 
{
    areaT = ((a+b)*c)/2;
    WriteLine($"area do trapézio é: {areaT}");
}