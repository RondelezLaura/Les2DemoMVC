using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Les2DemoMVC.Controllers
{
    public class HomeController : Controller
    {
        public string Index(string name)
        {
            return $"Ugh {name}";
        }
    }
}