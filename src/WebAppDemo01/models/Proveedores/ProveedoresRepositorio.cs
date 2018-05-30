using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebAppDemo01.models
{
    public class ProveedoresRepositorio : IProveedoresRepositorio
    {
        private readonly AppDbContext _appDbContext;

        public ProveedoresRepositorio(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Proveedores> Proveedores
        {
            get
            {
                return _appDbContext.Proveedores;
            }
        }

       /* public IEnumerable<Proveedores> ProveedoresInactivos
        {
            get
            {
                return _appDbContext.Proveedores.Include(p => p.ProveedoresInactivos).Where(p => p.ProveedoresInactivos);
            }
        }*/

        public Proveedores GetProveedoresPorCodigo(int CodigoProveedores)
        {
            return _appDbContext.Proveedores.FirstOrDefault(cp => cp.CodigoProveedores == CodigoProveedores);
        }
    }
}
