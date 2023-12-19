using ProjectGitVS.Models;

namespace ProjectGitVS.Servicios
{
    public class TipoUsuarioServicio
    {
        public List<TipoUsuario> All()
        {
            List<TipoUsuario> listOfTypeUsers = new List<TipoUsuario>()
            {
                new TipoUsuario() { Id = 1, Nombre = "Administrador"},
                new TipoUsuario() { Id = 2, Nombre = "Cliente"},
            };
            return listOfTypeUsers;
        }
    }
}
