 using static System.Console;
//Declarar as variaveis
int numero, valor;
try
{
    //Entrada de dados
    Write("Quantos números você vai digitar?");
    numero = int.Parse(ReadLine());
    //Processamentos de dados
    for (int i = 0; i<numero; i++)
    {
    WriteLine("Digite um número: ");
    valor = int.Parse(ReadLine()); 
    //Teste de valores positivos, negativos e nulos
    if (valor <0)
    {
    Write("Negativo ");
    }
    else if (valor >0)
    {
    Write ("Positivo"); 
    }
    else
        {
        Write ("Nulo");
        }
    if ((valor % 2) ==0)
        {
            WriteLine(" PAR");
        }
        else if ((valor % 2) !=0)
        {
            WriteLine(" IMPAR");
        }
}
}
catch (Exception ex)
{
    WriteLine("$Valor invalido, erro = {ex.Message}");
}