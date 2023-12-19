using Microsoft.AspNetCore.Mvc;
using ProjectGitVS.Servicios;

namespace ProjectGitVS.Controllers
{
    public class TipoUsuarioController : Controller
    {
        private readonly TipoUsuarioServicio tipoUsuarioServicio;

        public TipoUsuarioController(TipoUsuarioServicio tipoUsuarioServicio)
        {
            this.tipoUsuarioServicio = tipoUsuarioServicio;
        }
        public IActionResult Index()
        {
            var tiposUsuario = tipoUsuarioServicio.All();
            return View(tiposUsuario);
        }
    }
}
