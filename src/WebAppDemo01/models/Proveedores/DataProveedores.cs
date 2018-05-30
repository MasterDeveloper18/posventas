using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace WebAppDemo01.models
{
    public static class DataProveedores
    {
        
        public static void AgregarData(IApplicationBuilder ab)
        {
            AppDbContext contexto = ab.ApplicationServices.GetRequiredService<AppDbContext>();


            if (!contexto.Proveedores.Any())
            {

                contexto.AddRange
                (
                    new Proveedores { NombreProveedor = "Almacenes Siman", NombreContacto = "Nayib Bukele", CargoContacto = "Gerente", Direccion = "San Salvador El Salvador", Telefono = 25698745, Email = "siman@gmal.com", Notas = "Exelente Proveedore", ProveedoresInactivos = true,  ImagenURL= "/Imagenes/Proveedores/siman.jpg" },
                    new Proveedores { NombreProveedor = "Omnisport", NombreContacto = "Petronilo", CargoContacto = "Jefe de area de compras", Direccion = "San Salvador El Salvador", Telefono = 25146985, Email = "omnisport@gmal.com", Notas = "Apopa tiene malas practicas", ProveedoresInactivos = false, ImagenURL = "/Imagenes/Proveedores/omnisport.jpg" },
                    new Proveedores { NombreProveedor = "Wallmart", NombreContacto = "Carlos", CargoContacto = "Jefe de Bodega", Direccion = "San Salvador El Salvador", Telefono = 26986945, Email = "Petronck@gmal.com", Notas = "Es un buen proveedor", ProveedoresInactivos = true,  ImagenURL = "/Imagenes/Proveedores/wallmart.jpg" },
                    new Proveedores { NombreProveedor = "PC Mundo", NombreContacto = "Alberto Ramos", CargoContacto = "Gerente", Direccion = "San Salvador El Salvador", Telefono = 25698745, Email = "pcmundo@gmal.com", Notas = "Exelente Proveedore", ProveedoresInactivos = true, ImagenURL = "/Imagenes/Proveedores/pcmundo.jpg" },
                    new Proveedores { NombreProveedor = "Curacao", NombreContacto = "Carlos Calleja", CargoContacto = "Jefe de area de compras", Direccion = "San Salvador El Salvador", Telefono = 25146985, Email = "Chume@gmal.com", Notas = "Apopa tiene malas practicas", ProveedoresInactivos = false, ImagenURL = "/Imagenes/Proveedores/curacao.jpg" }


                );
            }

            contexto.SaveChanges();
        }//fin de agregarData

    }
}



