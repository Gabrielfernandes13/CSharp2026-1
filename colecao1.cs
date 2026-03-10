using static System.Console;

int [] numeros = new int [5];

string [] nomes = {"Joao", "Maria", "Pedro", "Ana", "Lucas"};
numeros [0] = 10;
numeros [1] = 10;
numeros [2] = 0;
System.Console.WriteLine( numeros [1]);
numeros [3] = 5;
numeros [4] = 7;
int tamanho = numeros.Length;
System.Console.WriteLine("O tamanho do vetor´:" + tamanho);
numeros.GetType();