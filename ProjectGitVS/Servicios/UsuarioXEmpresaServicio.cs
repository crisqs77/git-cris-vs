using ProjectGitVS.Models;

namespace ProjectGitVS.Servicios
{
    public class UsuarioXEmpresaServicio
    {
        public List<UsuarioXEmpresa> All()
        {
            List<UsuarioXEmpresa> listOfUsersXEnterprise = new List<UsuarioXEmpresa>()
            {
                new UsuarioXEmpresa() { IdEmpresa = 1, IdUsuario = 2 },
                new UsuarioXEmpresa() { IdEmpresa = 1, IdUsuario = 3 },
                new UsuarioXEmpresa() { IdEmpresa = 2, IdUsuario = 1 },
                new UsuarioXEmpresa() { IdEmpresa = 3, IdUsuario = 2 },
                new UsuarioXEmpresa() { IdEmpresa = 4, IdUsuario = 3 },
            };
            return listOfUsersXEnterprise;
        }
    }
}
