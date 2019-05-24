using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProyProg.Models;

namespace ProyProg.Controllers
{
    public class AdminController : Controller
    {


        private ProyectoContext _context { get; }

        public AdminController(ProyectoContext context) {
            _context = context;
        }
    
    
        public IActionResult Inicio()
        {
            return View();
        }

        public IActionResult RegistrarClienteAdmin()
        {
            return View();
        }



        public IActionResult Admin(){
            var listaC = _context.Cliente.ToList();

            return View(listaC);
        }
    

        [HttpPost]
        public IActionResult RegistrarClienteAdmin(Cliente c)
        {
            if(ModelState.IsValid){
                _context.Cliente.Add(c);
                _context.SaveChanges();
            }

            return View(c);
        }

    }
}
