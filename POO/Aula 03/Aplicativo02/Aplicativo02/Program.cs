using static System.Console;
   
    Funcionario f = new Funcionario();

    Console.WriteLine("Digite o nome do funcionario: ");
    f.nome = Console.ReadLine();

    Console.WriteLine("Digite o salario bruto do funcionario: ");
    f.salariobruto = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite o valor total do imposto pago pelo funcionario: ");
    f.imposto = double.Parse(Console.ReadLine());
       
    Console.WriteLine("Dados do funcionario: ");
    Console.WriteLine("Nome" + f.nome);
    Console.WriteLine("Salario liquido R$" + f.SalarioLiquido().ToString("F2"));

    Console.WriteLine();
    Console.WriteLine("Digite a porcentagem de aumento do salario: ");
    double porcentagem = double.Parse(Console.ReadLine());

    f.AumentarSalario(porcentagem);

    Console.WriteLine();
    Console.WriteLine("Dados atualizados:");
    Console.WriteLine("Nome:" + f.nome);
    Console.WriteLine("Salario bruto R$" + f.salariobruto.ToString("F2"));

ReadKey();