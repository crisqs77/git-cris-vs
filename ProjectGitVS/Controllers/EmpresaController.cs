using Microsoft.AspNetCore.Mvc;
using ProjectGitVS.Servicios;

namespace ProjectGitVS.Controllers
{
    public class EmpresaController : Controller
    {
        private readonly EmpresaServicio empresaServicio;

        public EmpresaController(EmpresaServicio empresaServicio)
        {
            this.empresaServicio = empresaServicio;
        }
        public IActionResult Index()
        {
            var empresas = empresaServicio.All();
            return View(empresas);
        }
    }
}
