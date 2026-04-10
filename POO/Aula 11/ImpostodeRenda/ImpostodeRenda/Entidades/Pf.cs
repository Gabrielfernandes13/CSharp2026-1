namespace ImpostodeRenda.Entidades
{
    abstract class Pf : Contribuintes
    {
        public double GastosSaude { get; set; }
        public Pf(string nome, double rendaAnual, double gastoSaude) : base(nome, rendaAnual)
        {
            GastosSaude = gastoSaude;
        }
        public override double Imposto()
        {
            double imposto;

            if
            (RendaAnual < 20000.00)
            {
                imposto = RendaAnual * 0.15;
            }
            else
            {
                imposto = RendaAnual * 0.25;
                imposto -= GastosSaude * 0.5;

                return imposto;
            }

            return imposto;
        }
    }
}

        

    
