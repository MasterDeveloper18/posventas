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
    public class UsuariosController : Controller
    {

        //objetos de solo lectura que sera instancias de las clases repositorios
        private readonly ICatUsuariosRepositorio _catUsuariosRepositorio;
        private readonly IUsuariosRepositorio _UsuariosRepositorio;

        //constructor de esta clase controller
        public UsuariosController(ICatUsuariosRepositorio catUsuariosRepositorio, IUsuariosRepositorio UsuariosRepositorio)
        {
            _catUsuariosRepositorio = catUsuariosRepositorio;
            _UsuariosRepositorio = UsuariosRepositorio;
        }//fin del constructor

        //metodo para devolber la vista con datos iyectados
        public ViewResult ListaUsuarios()
        {
            //objetos para mostrar las categorias de los productos
            ListaUsuariosViewModel listausuariosViewModel = new ListaUsuariosViewModel();
            listausuariosViewModel.Usuarios = _UsuariosRepositorio.Usuarios;

            //pasando intencionalmente un valor a la variable de la clase
            listausuariosViewModel.CategoriasUsuarios = "Lista de Usuarios";


            // return View(_productosRepositorio.Productos);
            return View(listausuariosViewModel);
        }//fin del metodo listaProductos
    }
}
