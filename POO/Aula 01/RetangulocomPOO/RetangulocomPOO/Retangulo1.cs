using System;
using System.Collections.Generic;
using System.Text;

namespace RetangulocomPOO
{
    internal class Retangulo1
    {
    public double altura;
    public double largura;
    public double Area()
    {
            double area = largura * altura;
            return area;
    }
    public double Perimetro()
    {
        double perimetro = (largura * 2) + (altura * 2);
        return perimetro;
    }
    public double Diagonal()
    {
        double diagonal = Math.Sqrt((largura * largura) + (altura * altura));
        return diagonal;
    }
}
}
