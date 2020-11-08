using GerenciadorContatos.Models;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorContatos.DataBase
{
    public class ContatoContext : DbContext
    {
        public ContatoContext(DbContextOptions options) : base(options) { }

        public DbSet<Contato> Contatos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*List<Contato> contatos = new List<Contato>();
            Random r = new Random();

            for (int i = 0; i < 10; i++)
            {
                contatos.Add(new Contato()
                {
                    Celular = $"({r.Next(10, 99)}) 9{r.Next(1000, 9999)}-{r.Next(1000, 9999)}",
                    Email = $"{Generate.GenerateName(4)}@hotmail.com",
                    Nome = Generate.GenerateName(8),
                    SobreNome = Generate.GenerateName(5)
                });
            }

            modelBuilder.Entity<Contato>().HasData(contatos);
*/
            modelBuilder.Entity<Contato>().Property(c => c.Email).IsRequired();
            modelBuilder.Entity<Contato>().Property(c => c.Nome).IsRequired();
            modelBuilder.Entity<Contato>().Property(c => c.SobreNome).IsRequired();


            base.OnModelCreating(modelBuilder);
        }
    }
}
