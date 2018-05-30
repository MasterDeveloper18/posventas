using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDemo01.models
{
    public class Clientes
    {
        [Key]
        public int CodigoClientes { get; set; }
        public string Imagenes { get; set; }
        public string NombreClientes { get; set; }
        public string ApellidoClientes { get; set; }
        public string Sexo { get; set; }
        public string FechaNacimiento { get; set; }
        public string TipoDocumento { get; set; }
        public int NumDocumento { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }
        public virtual ClientesDetalle ClientesDetalle { get; set; }
    }
}