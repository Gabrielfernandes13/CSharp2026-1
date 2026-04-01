namespace BancoMaster
{
    internal class Conta
    {
        //Campos
        private int numero;
        private string titular;
        private double saldo;


        //Propriedades
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string Titular
        {
            get { return titular; }
            set { titular = value; }
        }
        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
        //Contrutor
        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public Conta(int numero, string titular) : this(numero, titular, 0)

        {
            saldo = 0;
        }

        //Métodos
        public virtual void Saque(double qtd)
        {
            saldo -= qtd + 5.00;
        }
        public void Deposito(double qtd)
        {
            saldo += qtd;
        }
    }
}