﻿namespace ProjectGitVS.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public TipoUsuario Tipo { get; set; }
    }
}
