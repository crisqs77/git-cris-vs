using ProjectGitVS.Models;

namespace ProjectGitVS.Servicios
{
    public class UsuarioServicio
    {

        public List<Usuario> All()
        {
            List<Usuario> listOfUsers = new List<Usuario>()
            {
                new Usuario() { Id = 1, Nombre = "John Doe", Edad = 42 },
                new Usuario() { Id = 2, Nombre = "Jane Doe", Edad = 34 },
                new Usuario() { Id = 3, Nombre = "Joe Doe", Edad = 7 },
            };
            return listOfUsers;
        }
    }
}
