using Microsoft.AspNetCore.Mvc;
using ProjetoMcvSimples.Models;
using System.Collections.Generic;

namespace ProjetoMcvSimples.Controllers
{
    public class DepartamentsController : Controller
    {
        public IActionResult Index()
        {
            List<Departament> departaments = new List<Departament>();
            departaments.Add(new Departament { Id = 1, Name = "Games" });
            departaments.Add(new Departament { Id = 2, Name = "VIDEO GAEMS" });

            return View(departaments);
        }
    }
}
