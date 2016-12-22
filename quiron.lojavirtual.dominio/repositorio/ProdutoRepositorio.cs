using System.Collections.Generic;
using quiron.lojavirtual.dominio.entidades;

namespace quiron.lojavirtual.dominio.repositorio
{
    public class ProdutoRepositorio
    {
        private readonly EfdbContext _context = new EfdbContext();

        public IEnumerable<Produto> Produtos
        {
            get { return _context.Produtos; }
        }
    }
}
