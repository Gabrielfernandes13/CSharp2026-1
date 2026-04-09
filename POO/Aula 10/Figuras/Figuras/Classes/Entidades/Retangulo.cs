using Figuras.Classes.Enumeracoes;
using System.Runtime;

namespace Figuras.Classes.Entidades
{
    internal class Retangulo : Forma
    {
		//Campos
		private double largura;
		private double altura;


        //Propriedades
        protected double Altura
		{
			get { return altura; }
			set { altura = value; }
		}


		protected double Largura
		{
			get { return largura; }
			set { largura = value; }
		}

        //Construtor
        public Retangulo(Cor corDaForma, double largura, double altura) : base(corDaForma)
        {
			Largura = largura;
			Altura = altura;
        }
        /// <summary>
        ///  Calcula a àrea da forma usando as dimensões atuais
        /// </summary>
        /// <returns></returns>O valor da área calculada com base na largurae altura do retângulo. </returns>
        public override double Area() => Largura * Altura;

    }
}
