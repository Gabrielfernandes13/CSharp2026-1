namespace Master
{
    internal class Conta : IOperacao
    {
        //Campos
        private Pessoa cliente;
        private int numero;
        private double saldo;

        public Conta(int numeroConta, double saldoConta, Pessoa dadosCliente)
        {
            NumeroConta = numeroConta;
            SaldoConta = saldoConta;
            DadosCliente = dadosCliente;
        }

        //Propriedade
        public int NumeroConta
        {
            get { return numero; }
            set { numero = value; }
        }
        public double SaldoConta
        {
            get { return saldo; }
            set { saldo = value; }
        }
        public Pessoa DadosCliente
        {
            get { return cliente; }
            set { cliente = value; }
        }


        //Construtores

        //Métodos
        public void Deposito(double qtd)
        {
           saldo = qtd;
        }

        public void Saque(double qtd)
        {
            saldo -= qtd;
        }
        public override string ToString()
        {
            return $"Dados da conta - {Tipo.ContaNormal} " +
                $"\n\tNome do titular: {cliente.nome}" +
                $"\n\tCPF do titular: {cliente.cpf}" +
                $"\n\tNúmero da conta: {numero}" +
                $"\n\tSaldo da conta: {saldo:C}";
        }
    }
}