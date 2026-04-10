namespace ImpostodeRenda.Entidades
{
    class Pj : Contribuintes
    {
        public int NumeroFuncionarios { get; set; }
        public Pj(string nome, double rendaAnual, int numeroFuncionarios) : base(nome, rendaAnual)
        {
            NumeroFuncionarios = numeroFuncionarios;
        }
        public override double Imposto()
        {
            double imposto;
            if (NumeroFuncionarios > 10)
                return RendaAnual * 0.14;
            else
            {
                return RendaAnual * 0.16;
            }
        }
    }
}

        

