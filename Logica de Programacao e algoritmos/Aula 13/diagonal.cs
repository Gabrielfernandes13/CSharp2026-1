using static System.Console;
int n;
Write(" Matriz até 10");
n = int.Parse(ReadLine());
int[,] matriz = new int[n, n];  
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Write($"Digite o valor para a posição [{i}, {j}]: ");
        matriz[i, j] = int.Parse(ReadLine());
    }
} 
WriteLine("Diagonal principal:");
for (int i = 0; i < n; i++)
{
    Write(matriz[i, i] + "\t");
}
WriteLine();
WriteLine("Quantidade de negativos na diagonal principal:");
int countNegativos = 0;
for (int i = 0; i < n; i++)
{
    if (matriz[i, i] < 0)
    {
        countNegativos++;
    }
}
WriteLine(countNegativos);

