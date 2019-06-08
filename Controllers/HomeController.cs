using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProyectoProgra1.Models;
using Microsoft.EntityFrameworkCore;
using ProyectoProgra1.Data;

namespace ProyectoProgra1.Controllers
{
    public class HomeController : Controller
    {

        private ClienteDbContext _context;

        public HomeController(ClienteDbContext c){
            _context = c;
        }

        
        public IActionResult Index()
        {
        return View();
        }
public IActionResult Registro(){
    ViewBag.Tipos = _context.Tipos.ToList();

    return View();
}

         [HttpPost]
         public IActionResult Registro(Cliente c){
             if(ModelState.IsValid){
                 _context.Add(c);
                 _context.SaveChanges();

                 return RedirectToAction("Registrate");
             }
         }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
