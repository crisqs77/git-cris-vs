using Microsoft.AspNetCore.Mvc;
using ProjectGitVS.Servicios;

namespace ProjectGitVS.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly UsuarioServicio usuarioServicio;

        public UsuarioController(UsuarioServicio usuarioServicio) {
            this.usuarioServicio = usuarioServicio;
        }
        public IActionResult Index()
        {
            var usuarios = usuarioServicio.All();
            return View(usuarios);
        }
    }
}
