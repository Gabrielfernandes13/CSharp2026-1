using System;
class Funcionario
{
    public string nome;
    public double salariobruto;
    public double imposto;
    public double SalarioLiquido()
    {
        return salariobruto - imposto;
    }
    public void AumentarSalario(double porcentagem)
    {
        salariobruto = salariobruto + (salariobruto * (porcentagem / 100));

    }
    public string DadosdoFuncionario()
    {
        return $"Nome: {nome} Salario Bruto:{salariobruto} Imposto: {imposto}" +
            $"Salario Liquido: {SalarioLiquido()}";
    }
    public string SalarioAtualizado()
    {
        return $"Nome {nome} Salario: {salariobruto}";
    }
}
