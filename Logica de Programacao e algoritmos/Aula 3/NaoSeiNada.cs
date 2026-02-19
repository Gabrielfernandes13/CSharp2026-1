using System.Data;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Reflection.Emit;

double x, y, media;
Console.WriteLine("Digite o primeiro número: ");
x=double.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo número: ");
y=double.Parse(Console.ReadLine());
media = (x+y)/2.0;
Console.WriteLine("Média = " + media);