namespace ImpostodeRenda.Entidades
{
    class Pf : Contribuintes
    {
        public double GastosSaude { get; set; }
        public Pf(string nome, double rendaAnual, double gastosSaude) : base(nome, rendaAnual)
        {
            GastosSaude = gastosSaude;
        }
        public override double Imposto
        {
            get
            {
                double imposto;
                if (RendaAnual < 20000.00)
                    imposto = RendaAnual * 0.15 - GastosSaude * 0.5;
                else
                    imposto = RendaAnual * 0.25 - GastosSaude * 0.5;
                if (imposto < 0)
                    return 0;
                else
                    return imposto;
            }
        }
    }
}



