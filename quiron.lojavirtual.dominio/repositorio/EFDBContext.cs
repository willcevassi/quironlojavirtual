using System.Data.Entity;
using quiron.lojavirtual.dominio.entidades;

namespace quiron.lojavirtual.dominio.repositorio
{
    public class EfdbContext:DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
    }
}
