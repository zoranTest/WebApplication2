using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;



// na trecoj grani napravljen

namespace WebApplication2.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult Exit()
        {
            // ova exit metoda je dodata preko treceGrane
            return View();
        }

    }




}
