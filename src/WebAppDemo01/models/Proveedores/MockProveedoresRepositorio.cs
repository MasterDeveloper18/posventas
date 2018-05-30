using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDemo01.models
{
    public class MockProveedoresRepositorio : IProveedoresRepositorio
    {
       

        public IEnumerable<Proveedores> Proveedores
        {
            get
            {
                return new List<Proveedores>
                {
                    new Proveedores {CodigoProveedores = 1, NombreProveedor = "carlos", NombreContacto = "Chumelo", CargoContacto = "Gerente", Direccion = "San Salvador El Salvador", Telefono = 25698745, Email = "carlos@gmal.com", Notas = "Buen cliente"},
                    new Proveedores {CodigoProveedores = 2, NombreProveedor = "Chumelo", NombreContacto = "Petronilo", CargoContacto = "Jefe de area de compras", Direccion = "San Salvador El Salvador", Telefono = 25146985, Email = "Chume@gmal.com", Notas = "Apopa tiene malas practicas"},
                    new Proveedores {CodigoProveedores = 3, NombreProveedor = "Petronilo", NombreContacto = "Carlos", CargoContacto = "Jefe de Bodega", Direccion = "San Salvador El Salvador", Telefono = 26986945, Email = "Petronck@gmal.com", Notas = "Es un buen cliente"},


                };
            }//fin del get
        }//fin de IEnumerable Productos

        public IEnumerable<Proveedores> NombreProveedor { get; }
        public Proveedores GetProveedoresPorCodigo(int CodigoProveedores)
        {
            throw new System.NotImplementedException();
        }
    }//fin de public class
}
