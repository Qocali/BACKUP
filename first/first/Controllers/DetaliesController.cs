using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace first.Controllers
{
    public class DetaliesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Action()
        {
            return View();
        }
        public IActionResult Else()
        {
            return View();
        }

    }
}
