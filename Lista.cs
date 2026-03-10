using static System.Console; 
using static System.Linq.Enumerable;

List <string> nomes = new List<string>();
nomes.Add("Joao");
nomes.Add("Maria");
nomes.Add("Clodoaldo");
nomes.Add("Maria");
foreach (var item in Range(0, nomes.Count))
{
WriteLine(nomes[item]);
}
nomes.Remove("Maria");
foreach (var item in Range(0, nomes.Count))
{
    WriteLine(nomes [item]); 
}
System.Console.WriteLine("---------------");
WriteLine("Indice que contém 'Joao': "+ nomes.Contains("Joao"));
nomes.Clear();
foreach (var item in Range(0, nomes.Count))
{
    WriteLine(nomes[item]);
}
nomes.Contains("Joao");