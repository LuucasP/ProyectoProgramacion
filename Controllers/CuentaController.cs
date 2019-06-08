using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProyectoProgramacion.Models;
using ProyProg.Models;

namespace ProyectoProgramacion.Controllers
{
    public class CuentaController : Controller
    {

        private ProyectoContext _context;

        private UserManager<IdentityUser> _userManager;
        private SignInManager<IdentityUser> _signInManager;

        public CuentaController(
            ProyectoContext c,
            UserManager<IdentityUser> um,
            SignInManager<IdentityUser> sim
        ){
            _context = c;
            _userManager = um;
            _signInManager = sim;
        }

        public IActionResult Registrar(){
            return View();
        }

        [HttpPost]        
        public IActionResult Registrar(Cliente model){
            if(ModelState.IsValid){
                var user = new IdentityUser();
                user.UserName = model.Usuario;
                user.Email = model.Email;
                
              //  var u = _context.Cliente.Add(model);
                var resultado = _userManager.CreateAsync(user,model.Password);
                
                if(resultado.Result == IdentityResult.Success){
                    return RedirectToAction("inicio", "home");
                }else{
                    foreach(var error in resultado.Result.Errors){
                        ModelState.AddModelError("error", error.Description);
                    }
                }
            }
            return View(model);
        }

        public IActionResult Login(){
            return View();
        }


        [HttpPost]
        public IActionResult Login(LoginCliente model){
            if(ModelState.IsValid){
                var resultado = _signInManager.PasswordSignInAsync(model.Usuario,model.Password,false,false);
            
            if(resultado.Result.Succeeded){
                return RedirectToAction("Inicio", "Home");
            }else{
                ModelState.AddModelError("error","Usuario o contraseña incorrecta");
            }
            
            }
            return View(model);
        }

        public IActionResult Logout(){
            _signInManager.SignOutAsync();
            return RedirectToAction("Inicio", "Home");
        
        }
    }


   
    }

