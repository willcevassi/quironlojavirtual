using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using quiron.lojavirtual.dominio.entidades;

namespace quiron.lojavirtual.dominio.repositorio
{
    public class EfdbContext:DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        //sobreescrita do método OnModelCreationg forçando a desativação da pluralização utilizada por padrão pelo Entity Framework
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //desativando a pluralização automática do Entity
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //ensiando o entity que a Classe Produto é referenciada no Bando de dados como a tabela "produtos"
            modelBuilder.Entity<Produto>().ToTable("produtos");
            base.OnModelCreating(modelBuilder);
        }
    }
}
