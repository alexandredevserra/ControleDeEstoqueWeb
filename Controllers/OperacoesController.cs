using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ControleEstoque.Web.Controllers
{
    public class OperacoesController : Controller
    {
        // GET: /<controller>/
        public IActionResult EntradaEstoque()
        {
            return View();
        }

        public IActionResult SaidaEstoque()
        {
            return View();
        }

        public IActionResult LancPerdaProduto()
        {
            return View();
        }

        public IActionResult Inventario()
        {
            return View();
        }
    }
}
