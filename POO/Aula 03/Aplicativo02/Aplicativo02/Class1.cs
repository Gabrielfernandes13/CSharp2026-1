using System;
class Funcionario
{
    public string nome;
    public double salariobruto;
    public double imposto;
    public double salario_liquido()
    {
        return salariobruto - imposto;
    }
    public void AumentarSalario(double porcentagem)
    {
        salariobruto = salariobruto + (salariobruto * porcentagem / 100);
    }
}