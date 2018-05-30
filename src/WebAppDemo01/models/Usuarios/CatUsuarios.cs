using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDemo01.models
{
    public class CatUsuarios
    {
        [Key]
        public int CodigoCatUo { get; set; }
        public string NombreCatUo { get; set; }
        public string DescripcionCatUo { get; set; }
        public List<Usuarios> Usuarios { get; set; }
    }
}
