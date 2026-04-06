using Master;

Console.WriteLine(Tipo.ContaNormal);
Conta conta = new Conta(12345, 11500.56, new Pessoa("Clodoaldo", 40689710023));

var a = conta.ToString();
Console.WriteLine(a);

Console.WriteLine(Tipo.ContaPJ);
ContaPJ pj = new ContaPJ(54321, 50000, new Pessoa("César", 501987100010), 2000);

var b = pj.ToString();
Console.WriteLine(b);

Console.WriteLine(Tipo.ContaPoupanca);
ContaPoupanca pp = new ContaPoupanca(66666, 666.66, new Pessoa("Lu", 666666), 5.0);

pp.Consulta();

Console.ReadKey();