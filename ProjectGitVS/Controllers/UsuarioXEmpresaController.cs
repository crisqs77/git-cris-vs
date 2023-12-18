using Microsoft.AspNetCore.Mvc;
using ProjectGitVS.Servicios;

namespace ProjectGitVS.Controllers
{
    public class UsuarioXEmpresaController : Controller
    {
        private readonly UsuarioXEmpresaServicio usuarioXEmpresaServicio;
        public UsuarioXEmpresaController(UsuarioXEmpresaServicio usuarioXEmpresaServicio)
        {
            this.usuarioXEmpresaServicio = usuarioXEmpresaServicio;
        }

        public IActionResult Index()
        {
            var usuarioXEmpresa = usuarioXEmpresaServicio.All();
            return View(usuarioXEmpresa);
        }
    }
}
