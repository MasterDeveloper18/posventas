using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;//operaciones con las conexiones

namespace WebAppDemo01.models
{
    public class CatUsuariosRepositorio : ICatUsuariosRepositorio
    {
        private readonly AppDbContext _appDbContext;

        //metodo constructor 
        public CatUsuariosRepositorio(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;

        }//fin del constructor

        //extension de los metodos disponibles en la clase interface
        public IEnumerable<CatUsuarios> CategoriasUsuarios => _appDbContext.CategoriasUsuarios;
    }
}
