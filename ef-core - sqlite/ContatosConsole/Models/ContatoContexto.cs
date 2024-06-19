using Microsoft.EntityFrameworkCore;

namespace ContatosConsole.Models
{
    public class ContatoContexto : DbContext
    {
        public ContatoContexto(DbContextOptions<ContatoContexto> options) : base(options)
        {
        }
        public DbSet<Contato> Contatos { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
               builder.Entity<Contato>().HasKey(m => m.Id);
               base.OnModelCreating(builder);
        }
    }
}