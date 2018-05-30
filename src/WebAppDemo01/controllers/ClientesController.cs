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
    public class ClientesController : Controller
    {

        //objetos de solo lectura que sera instancias de las clases repositorios
        private readonly IClientesDetalleRepositorio _clientesDetalleRepositorio;
        private readonly IClientesRepositorio _clientesRepositorio;

        //constructor de esta clase controller
        public ClientesController(IClientesDetalleRepositorio clientesDetalleRepositorio, IClientesRepositorio clientesRepositorio)
        {
            _clientesDetalleRepositorio = clientesDetalleRepositorio;
            _clientesRepositorio = clientesRepositorio;
        }//fin del constructor

        //metodo para devolber la vista con datos iyectados
        public ViewResult ListaClientes()
        {
            //objetos para mostrar las categorias de los productos
            ListaClientesViewModel listaclientesViewModel = new ListaClientesViewModel();
            listaclientesViewModel.Clientes = _clientesRepositorio.Clientes;

            //pasando intencionalmente un valor a la variable de la clase
            listaclientesViewModel.ListaClientes = "Lista de Clientes";


            // return View(_productosRepositorio.Productos);
            return View(listaclientesViewModel);
        }//fin del metodo listaProductos
    }
}
