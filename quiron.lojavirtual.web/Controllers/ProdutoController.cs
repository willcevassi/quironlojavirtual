using quiron.lojavirtual.dominio.repositorio;
using System.Linq;
using System.Web.Mvc;

namespace quiron.lojavirtual.web.Controllers
{
    public class ProdutoController : Controller
    {
        private ProdutoRepositorio _repositorio;

        // GET: Produto
        public ActionResult Index()
        {
            _repositorio = new ProdutoRepositorio();
            var produtos = _repositorio.Produtos.Take(10);

            return View(produtos);
        }
    }
}