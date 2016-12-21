using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace quiron.lojavirtual.dominio.entidades
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }

        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public string Categoria { get; set; }


    }
}
