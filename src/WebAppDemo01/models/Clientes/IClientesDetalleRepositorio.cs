using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDemo01.models
{
    public interface IClientesDetalleRepositorio
    {
        IEnumerable<ClientesDetalle> ClientesDetalle { get; }
    }
}