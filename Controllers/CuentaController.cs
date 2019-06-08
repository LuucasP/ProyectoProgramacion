using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
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

        public IActionResult Registrar(Cliente model){
            if(ModelState.IsValid){
                var user = new IdentityUser();
                user.UserName = model.Usuario;
                user.Email = model.Email;
                
              //  var u = _context.Cliente.Add(model);
                var resultado = _userManager.CreateAsync(user,model.Password);
                
                if(resultado.Result == IdentityResult.Success){
                    return RedirectToAction("DashboardCliente", "Cliente");
                }else{
                    foreach(var error in resultado.Result.Errors){
                        ModelState.AddModelError("error", error.Description);
                    }
                }
            }
            return View(model);
        }

    }


}