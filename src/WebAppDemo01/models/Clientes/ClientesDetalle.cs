using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDemo01.models
{
    public class ClientesDetalle
    {
        [Key]
        public int CodigoCliDetalle { get; set; }
        public string NombreCliDetalle { get; set; }
        public string TipoCliente { get; set; }
        public string DetalleCliente { get; set; }
        public List<Clientes> Clientes { get; set; }
    }
}