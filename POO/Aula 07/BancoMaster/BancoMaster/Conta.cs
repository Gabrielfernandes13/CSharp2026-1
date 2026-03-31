using System.Security.Cryptography.X509Certificates;

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
		//Construtor
		public Conta(int numero, string titular, double saldo)
		{
			Numero = numero;
			Titular = titular;
			Saldo = saldo;
        }
        public Conta(int numero,string titular) : this(numero, titular, 0.0)
        {
        }
		//Métodos
		public void Depositar(double valor)
		{
			Saldo += valor;
		}
		public void Sacar(double valor)
		{
			Saldo -= valor;
		}
		public override string ToString()
		{
			return $"Dados do Cliente: " +
				$"\n\t Número: {Numero}" +
				$"\n\t Titular: {Titular}" +
				$"\n\t Saldo: R${Saldo:C}";
		}
    }
}



