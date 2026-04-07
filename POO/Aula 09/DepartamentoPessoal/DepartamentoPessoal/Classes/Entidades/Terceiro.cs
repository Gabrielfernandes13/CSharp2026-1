namespace DepartamentoPessoal.Classes.Entidades
{
    internal class Terceiro : Funcionario
    {
		//Campo
		private double despesa;


        //Propriedade
        protected double DespesaAdicional
		{
			get { return despesa; }
			set { despesa = value; }
		}

        //Construtor
        public Terceiro(string nomeColaborador, int jornadarabalho, double valorHora, double despesa) : base(nomeColaborador, jornadarabalho, valorHora)
        {
            DespesaAdicional = despesa;
        }

        //Método
        public override double Pagamento()
        {
            return base.Pagamento() + (DespesaAdicional * 0.2);
        }
	}
}
