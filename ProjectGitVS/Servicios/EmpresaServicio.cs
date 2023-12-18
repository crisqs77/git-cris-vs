using ProjectGitVS.Models;

namespace ProjectGitVS.Servicios
{
    public class EmpresaServicio
    {
        public List<Empresa> All()
        {
            List<Empresa> listOfCompanies = new List<Empresa>()
            {
                new Empresa() { Id = 1, Nombre = "Coca Cola", Eliminado = false, Estado = true },
                new Empresa() { Id = 2, Nombre = "Nuvel", Eliminado = false, Estado = false },
                new Empresa() { Id = 3, Nombre = "Yambal", Eliminado = true, Estado = false  },
                new Empresa() { Id = 4, Nombre = "Samsung", Eliminado = true, Estado = true  }
            };
            return listOfCompanies;
        }
    }
}
