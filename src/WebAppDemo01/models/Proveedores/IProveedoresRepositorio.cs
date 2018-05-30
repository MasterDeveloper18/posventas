using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebAppDemo01.models
{
    public interface IProveedoresRepositorio
    {
        IEnumerable<Proveedores> Proveedores { get; }
        Proveedores GetProveedoresPorCodigo(int CodigoProveedores);
    }
}
