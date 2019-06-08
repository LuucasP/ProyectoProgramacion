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

        // Promociones
        public IActionResult ListarPromociones(){
            var promociones = _context.Promociones.ToList();
            return View();
        }


        public IActionResult RegistrarPromociones(){
            return View();
        }

        [HttpPost]
        public IActionResult RegistrarPromociones(Promociones p){
            if(ModelState.IsValid){
                _context.Promociones.Add(p);
                _context.SaveChanges();

                return RedirectToAction("ListarPromociones");
            }
            return View(p);
        }


        public IActionResult ActualizarPromociones(int id){
            var p = _context.Promociones.FirstOrDefault(x => x.Id == id);
            if(p == null){
                return NotFound();
            }
            return View(p);
        }

        [HttpPost]
        public IActionResult ActualizarPromociones(Promociones p){
            if (ModelState.IsValid) {
                var promocionBd = _context.Promociones.Find(p.Id);

                promocionBd.Foto = p.Foto;
                promocionBd.Titulo = p.Titulo;
                promocionBd.Descripcion = p.Descripcion;
                promocionBd.Precio = p.Precio;
             

                _context.SaveChanges();

                return RedirectToAction("ListarPromociones");
            }

            return View(p);
            }


             public IActionResult BorrarPromociones(int id)
        {
            var p = _context.Promociones.FirstOrDefault(x => x.Id == id);

            if (p != null) {
                _context.Promociones.Remove(p);
                _context.SaveChanges();
            }

            return RedirectToAction("ListarPromociones");
        }


            //Tours

          public IActionResult ListarTours(){
            var promociones = _context.Tours.ToList();
            return View();
        }

         public IActionResult RegistrarTours(){
            return View();
        }

        [HttpPost]
        public IActionResult RegistrarTours(Tours p){
            if(ModelState.IsValid){
                _context.Tours.Add(p);
                _context.SaveChanges();

                return RedirectToAction("ListarTours");
            }
            return View(p);
        }

        public IActionResult ActualizarTours(int id){
            var p = _context.Tours.FirstOrDefault(x => x.Id == id);
            if(p == null){
                return NotFound();
            }
            return View(p);
        }

        [HttpPost]
        public IActionResult ActualizarTours(Tours p){
            if (ModelState.IsValid) {
                var toursBd = _context.Tours.Find(p.Id);

                toursBd.Foto = p.Foto;
                toursBd.Titulo = p.Titulo;
                toursBd.Descripcion = p.Descripcion;
                toursBd.Precio = p.Precio;
             

                _context.SaveChanges();

                return RedirectToAction("ListarTours");
            }

            return View(p);
            }



               public IActionResult BorrarTours(int id)
        {
            var p = _context.Tours.FirstOrDefault(x => x.Id == id);

            if (p != null) {
                _context.Tours.Remove(p);
                _context.SaveChanges();
            }

            return RedirectToAction("ListarTours");
        }

    }
}
