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
    
          public IActionResult ListarDestinos(){
            var listaD = _context.Destinos.ToList();

            return View("listaD");
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
            return View();
        }
     


        public IActionResult ListarCliente(){
            var listaC = _context.Cliente.ToList();

            return View(listaC);
        }


        public IActionResult RegistrarDestinos(){

            return View();
        }

    public IActionResult Dashboard(){
        return View();
    }

        [HttpPost]
        public IActionResult RegistrarDestinos(Destinos d){

            if(ModelState.IsValid){
                _context.Destinos.Add(d);
                _context.SaveChanges();
                return RedirectToAction("ListarDestinos");
            }

            return View(d);
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

         public IActionResult ActualizarDestino(int id)
        {
            var p = _context.Destinos.FirstOrDefault(x => x.Id == id);

            if (p == null) {
                return NotFound();
            }

            return View(p);
        }


        [HttpPost]
        public IActionResult ActualizarDestino(Destinos d)
        {
            if (ModelState.IsValid) {
                var destino = _context.Destinos.Find(d.Id);

              destino.Foto = d.Foto;
              destino.Titulo = d.Titulo;
              destino.Descripcion = d.Descripcion;
              destino.Precio = d.Precio;

                _context.SaveChanges();

                return RedirectToAction("ListarDestinos");
            }

            return View(d);
        }


         public IActionResult BorrarDestino(int id)
        {
            var p = _context.Destinos.FirstOrDefault(x => x.Id == id);

            if (p != null) {
                _context.Destinos.Remove(p);
                _context.SaveChanges();
            }

            return RedirectToAction("ListarDestinos");
        }

    }
}
