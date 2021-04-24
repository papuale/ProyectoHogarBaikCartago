using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hogarbaik.Controllers
{
    public class ReportesController : Controller
    {
        public IActionResult Reportes()
        {
            return View();
        }
    }
}
