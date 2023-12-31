﻿using ProjectGitVS.Models;

namespace ProjectGitVS.Servicios
{
    public class UsuarioServicio
    {
        public List<Usuario> All()
        {
            List<Usuario> listOfUsers = new List<Usuario>()
            {
                new Usuario() { Id = 1, Nombre = "John Doe", Edad = 42, Tipo = new TipoUsuario() { Id = 2, Nombre = "Cliente"} },
                new Usuario() { Id = 2, Nombre = "Jane Doe", Edad = 34, Tipo = new TipoUsuario() { Id = 1, Nombre = "Administrador"} },
                new Usuario() { Id = 3, Nombre = "Joe Doe", Edad = 7, Tipo = new TipoUsuario() { Id = 2, Nombre = "Cliente"} },
            };
            return listOfUsers;
        }
    }
}
