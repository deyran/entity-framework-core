# [Entity Framework Core - Usando o banco de dados SQLite](https://www.macoratti.net/17/04/efcore_sqlite1.htm)

1. Criando o projeto web Exemplo :  Contatos
2. Criando a entidade Contato na pasta Models

```
public class Contato
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Endereco { get; set; }
    public string Cidade { get; set; }
    public string Estado { get; set; }
    public string Cep { get; set; }
    public string Fone { get; set; }
    public string Email { get; set; }
}
```

3. Criando a classe de contexto do Banco de dados

```
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
```

4. A
5. A
6. A