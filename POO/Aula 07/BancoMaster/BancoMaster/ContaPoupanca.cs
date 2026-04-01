namespace BancoMaster
{
    internal class ContaPoupanca : Conta
    {
        //Campo
        private double juros;


        //Propriedade
        public double TaxaDeJuros
        {
            get { return juros; }
            set { juros = value; }
        }
        //Construtores
        public ContaPoupanca(int numero, string titular, double TaxaJuros) : base(numero, titular)
        {
            TaxaDeJuros = TaxaJuros;
        }

        public ContaPoupanca(int numero, string titular, double saldo, double TaxaJuros) : base(numero, titular, saldo)
        {
            TaxaDeJuros = TaxaJuros;
        }
        //Métodos
        public void AtualizarSaldo()
        {
            Saldo = Saldo + (Saldo * TaxaDeJuros);
        }
        public override void Saque(double qtd)
        {
         Saldo -= qtd;
        }
    }
}
