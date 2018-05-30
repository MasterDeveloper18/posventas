using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDemo01.models
{
    public class Usuarios
    {
        [Key]
        public int CodigoUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string ApellidoUsuario { get; set; }
        public string UserName { get; set; }
        public string Contraseña { get; set; }
        public string fechacreacion { get; set; }
        public bool UsuariosInactivos { get; set; }
        public bool ListaNegra { get; set; }
        public string ImagenUsuarioURL { get; set; }
        public virtual CatUsuarios CatUsuarios { get; set; }
    }
}
