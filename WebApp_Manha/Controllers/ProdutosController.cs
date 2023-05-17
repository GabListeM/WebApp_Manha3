using Microsoft.AspNetCore.Mvc;

namespace WebApp_Manha.Controllers
{
    public class ProdutosController : Controller
    {
        private Contexto db;

        public ProdutosController(Contexto contexto)
        {
            db = contexto;
        }

        public IActionResult Lista()
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }
    
    }
    [HttpPost]
       public IActionResult SalvarDados(Produtos dados)

    {
        db.Produtos.Add(dados);
        db.SaveChanges();
        return RedirectToAction("Lista")
    }
}
