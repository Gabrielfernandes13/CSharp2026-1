using static System.Console;
double contagem = 0, alturamaxima, alturaminima, alturapessoa;
try
{
    WriteLine("Digite o número de altura das pessoas");
    alturamaxima = double.Parse(ReadLine());
    WriteLine("Digite a altura maxima");
    alturamaxima = double.Parse(ReadLine());
    WriteLine("Digite a altura minima");
    alturaminima = double.Parse(ReadLine());
    for (double pessoa = 0; pessoa < 5; pessoa++)
    {
        WriteLine($"Digite a altura da pessoa {pessoa + 1}");
        double altura = double.Parse(ReadLine());
        if (altura >= alturaminima && altura <= alturamaxima)
        {
            WriteLine($"A pessoa {pessoa + 1} está apta para o brinquedo");
        }
        else (altura < alturaminima);
        {
            WriteLine($"A pessoa {pessoa + 1} não está apta para o brinquedo, altura abaixo do mínimo");

        }
        else  (altura > alturamaxima);
        {
            WriteLine($"A pessoa {pessoa + 1} não está apta para o brinquedo, altura acima do máximo");
        }
    }
}
catch (Exception ex)
{
    WriteLine($"O numero de pessoas com altura dentr do intervalo é {contagem}");
}
    



 