using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hogarbaik.Controllers
{
    public class BitacorasController : Controller
    {
        public IActionResult BitacoraInicio()
        {
            return View();
        }
    }
}
