using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyHowest;

namespace Les2DemoMVC.Controllers
{
    public class HomeController : Controller
    {
        public string Index(string name)
        {
            return $"Ugh {name}";
        }

        public ViewResult Student()
        {
            List<Student> studenten = new List<Student> { new MyHowest.Student {Id=23, Naam="nope", AfstudeerGraad=Graad.Voldoening },
            new MyHowest.Student {Id=25, Naam="ugh", AfstudeerGraad=Graad.Onderscheiding }};
            return View();
        }
    }
}