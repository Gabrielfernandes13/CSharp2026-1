using BancoMaster;
using static System.Console;
WriteLine("Escolha qual conta deseja abrir: \n" +
    "\t1 - Conta comum\n +" +
    "\t2 - Conta Poupanca\n +" +
    "\t3 - Conta Empresa");

int opcao = int.Parse(ReadLine());

switch (opcao)
{
    case 1:
        Conta conta;
        WriteLine("Digite o titular da conta: ");
        string titular = ReadLine();
        WriteLine("Digite o numero da conta: ");
        int numero = int.Parse(ReadLine());
        WriteLine("Deseja fazer deposito inicial? (s/n)");
        char escolha = char.Parse(ReadLine().ToLower());

        if (escolha == 's')
        {
            WriteLine("Digite o valor do deposito inicial: ");
            double depositoInicial = double.Parse(ReadLine());
            conta = new Conta(numero, titular, depositoInicial);

        }
        else
        {
            conta = new Conta(numero, titular);
        }
        break;
}
ReadKey();