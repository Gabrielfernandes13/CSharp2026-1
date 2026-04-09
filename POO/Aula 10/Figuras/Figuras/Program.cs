using Figuras.Classes.Entidades;
using Figuras.Classes.Enumeracoes;

//Forma geo1 = new Forma (Cor.Vermelho);
Forma geo2 = new Retangulo(Cor.Azul, 10, 10);
Forma geo3 = new Circulo(Cor.Rosa, 5);

Console.WriteLine ($"\nGeo 2 - Tipo Forma -> Retangulo : Area = {geo2.Area()}" +
                  $"\nGeo 3 - Tipo Forma -> Círculo : Area = {geo3.Area()}");

Console.ReadKey();