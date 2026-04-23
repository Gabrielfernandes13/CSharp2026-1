using Estudante.Classes.Dados;
using Estudante.Classes.Entidades;
using Microsoft.EntityFrameworkCore;

using var context = new AlunoContext();

Aluno pessoa1 = new Aluno("Cesar", 123456, "Python");
context.Alunos.Add(pessoa1);
context.SaveChanges();

var pessoas = context.Alunos.FirstOrDefault(c => c.Id == 1);
pessoas.ExibirDados();