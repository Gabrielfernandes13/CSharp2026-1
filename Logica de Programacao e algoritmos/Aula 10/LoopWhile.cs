using static System.Console;
//Declaração de variáveis
int totalTuristas = 0;
string fluxo = "";
WriteLine("Bem vindo ao aplicativo de controle de fluxo de carros!");
while (fluxo!= "sair")  
{
    Write("Digite o fluxo do carro (entrada/saída) ou 'sair' para encerrar: ");
    fluxo =ReadLine();
    if (fluxo == "sair")
    {
        break;
    }
    if (fluxo == "entrada" || fluxo == "saida")
    {
        Write("Digite o número de turistas no carro: ");
        int turistas = int.Parse(ReadLine());
        if (fluxo == "entrada")
        {
            totalTuristas = totalTuristas + turistas;
        }
        else
        {
            totalTuristas = totalTuristas - turistas;
        }
        WriteLine("Total de turistas no parque: " + totalTuristas);
    }
   
    }
    WriteLine("Encerrando o aplicativo");
    WriteLine("Total de turistas no parque: " + totalTuristas);
    