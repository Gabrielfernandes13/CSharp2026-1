using Microsoft.Identity.Client;

namespace Estudante.Classes.Entidades
{
    internal class Aluno
    {
        // Propriedades
        public int Id { get; set; }
        public string Nome { get; set; }
        public int RA { get; set; }
        public string Curso { get; set; }

        //Construtor
        public Aluno()
        {
        }
        public Aluno(string nome, int rA, string curso)
        {
            Nome = nome;
            RA = rA;
            Curso = curso;
        }

            //Método
            public void ExibirDados()
            {
                Console.WriteLine("--Dados do aluno--");
                Console.WriteLine($"Nome do Aluno: {Nome}");
                Console.WriteLine($"RA: {RA}");
                Console.WriteLine($"Curso matriculado: {Curso}");
        }
    }
    }

