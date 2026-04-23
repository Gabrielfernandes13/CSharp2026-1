using Microsoft.EntityFrameworkCore;
using SistemaBancario.Classes.Entidades;
namespace SistemaBancario.Classes.Contextos
{
internal class BancoContext : DbContext
{
        //Propriedades
        /// <summary>
        /// Representa a tabela de contas bancárias no banco de dados
        /// Dbset permite realizar operações CRUD (Create, Read, Update, Delete) nas contas
        /// </summary>
        public DbSet <Banco> contas { get; set; }

        //Métodos
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=localhost\SQLEXPRESS02;Database=BancoDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Banco>(entity=>
            {
                entity.HasKey(entity => entity.Id);
                entity.Property(e=>e.NumeroConta).IsRequired();
                entity.Property(e=>e.Titular).IsRequired().HasMaxLength(50);
                entity.Property(e=>e.Saldo).HasColumnType("decimal(18,2)");
            }
                
                );
        }
        }
}
