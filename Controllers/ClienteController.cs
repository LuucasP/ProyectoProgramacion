using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Base_de_Datos.Models;

namespace Base_de_Datos.Controllers
{
    public class ClienteController : Controller
    {

        private ProyectoContext _context { get; }

        public ClienteController(ProyectoContext context) {
            _context = context;
        }
  
    }
}
