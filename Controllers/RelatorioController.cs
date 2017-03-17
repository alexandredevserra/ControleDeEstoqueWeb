using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ControleEstoque.Web.Controllers
{
    public class RelatorioController : Controller
    {
        // GET: /<controller>/
        public IActionResult PosicaoEstoque()
        {
            return View();
        }

        public IActionResult Ressuprimento()
        {
            return View();
        }

    }
}
