using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ControleEstoque.Web.Controllers
{
    public class GraficoController : Controller
    {
        public IActionResult PerdaMes()
        {
            return View();
        }

        public IActionResult EntradaSaidaMes()
        {
            return View();
        }
    }
}