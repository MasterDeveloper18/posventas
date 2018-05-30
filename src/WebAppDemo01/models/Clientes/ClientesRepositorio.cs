using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDemo01.models
{
    public class ClientesRepositorio : IClientesRepositorio
    {
        private readonly AppDbContext _appDbContext;

        public ClientesRepositorio(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Clientes> Clientes
        {
            get
            {
                return _appDbContext.Clientes.Include(c => c.ClientesDetalle);
            }
        }

        public Clientes GetClientesPorCodigo(int CodigoClientes)
        {
            return _appDbContext.Clientes.FirstOrDefault(p => p.CodigoClientes == CodigoClientes);
        }

        Usuarios IClientesRepositorio.GetClientesPorCodigo(int CodigoClientes)
        {
            throw new NotImplementedException();
        }
    }
}
