using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDemo01.models
{
    public class Proveedores
    {
        [Key]
        public int CodigoProveedores { get; set; }
        public string NombreProveedor { get; set; }
        public string NombreContacto { get; set; }
        public string CargoContacto { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }
        public string Notas { get; set; }
        public bool ProveedoresInactivos { get; set; }
        public string ImagenURL { get; set; }


    }
}
