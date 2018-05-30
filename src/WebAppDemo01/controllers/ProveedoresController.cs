using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppDemo01.models;
using WebAppDemo01.viewmodels;


// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAppDemo01.Controllers
{
    public class ProveedoresController : Controller
    {

        //objetos de solo lectura que sera instancias de las clases repositorios
        
        private readonly IProveedoresRepositorio _ProveedoresRepositorio;

        //constructor de esta clase controller
        public ProveedoresController(IProveedoresRepositorio ProveedoresRepositorio)
        {
            
            _ProveedoresRepositorio = ProveedoresRepositorio;
        }//fin del constructor

        //metodo para devolber la vista con datos iyectados
        public ViewResult ListaProveedores()
        {
            //objetos para mostrar las categorias de los proveedores
            ListaProveedoresViewModel listaproveedoresViewModel = new ListaProveedoresViewModel();
            listaproveedoresViewModel.Proveedores = _ProveedoresRepositorio.Proveedores;

            //pasando intencionalmente un valor a la variable de la clase
            listaproveedoresViewModel.ProveedoresActivos = "Lista de Proveedores";


            // return View(_productosRepositorio.Productos);
            return View(listaproveedoresViewModel);
        }//fin del metodo listaProductos
    }
}
