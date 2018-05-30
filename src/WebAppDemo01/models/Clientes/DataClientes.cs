using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace WebAppDemo01.models
{
    public static class DataClientes
    {
        
        public static void AgregarDataClientes(IApplicationBuilder ab)
        {
            AppDbContext contexto = ab.ApplicationServices.GetRequiredService<AppDbContext>();

            if (!contexto.ClientesDetalle.Any())
            {
                //CategoriasProductosIniciales es una coleccion local
                contexto.ClientesDetalle.AddRange(TipoClientesIniciales.Select(c => c.Value));
            }
            if (!contexto.Clientes.Any())
            {
                contexto.AddRange
                (
                    new Clientes { Imagenes = "/Imagenes/Clientes/a.jpg", NombreClientes = "Juan", ApellidoClientes = "Perez", Sexo = "Masculino", FechaNacimiento = "02Agosto1988", TipoDocumento = "Dui", NumDocumento = 05473598, Direccion = "Santa Ana", Telefono = 25847836, Email = "Juan@gmail.com", ClientesDetalle = TipoClientesIniciales["Bueno"] },
                    new Clientes { Imagenes = "/Imagenes/Clientes/b.jpg", NombreClientes = "Berenice", ApellidoClientes = "Lopez", Sexo = "Femenino", FechaNacimiento = "12Abril1990", TipoDocumento = "Dui", NumDocumento = 00457819, Direccion = "San Salvador", Telefono = 25768146, Email = "Berenice@gmail.com", ClientesDetalle = TipoClientesIniciales["Excelente"] },
                    new Clientes { Imagenes = "/Imagenes/Clientes/c.jpg", NombreClientes = "Carlos", ApellidoClientes = "Ramirez", Sexo = "Masculino", FechaNacimiento = "25Junio1986", TipoDocumento = "Dui", NumDocumento = 00035489, Direccion = "Son Sonate", Telefono = 25698743, Email = "Carlos@gmail.com", ClientesDetalle = TipoClientesIniciales["Malo"] }



                );
            }

            contexto.SaveChanges();
        }//fin de agregarData

        //se hace referencia a la clase dominio ClientesDetalle
        public static Dictionary<string, ClientesDetalle> ClientesDetalleiniciales;
        public static Dictionary<string, ClientesDetalle> TipoClientesIniciales
        {
            get
            {
                if(ClientesDetalleiniciales == null)
                {
                    var listadoClientes = new ClientesDetalle[]
                    {
                        new ClientesDetalle { NombreCliDetalle = "Juan", TipoCliente ="Bueno", DetalleCliente = "Generalmente paga atiempo y si se retrasa en pagar son dias"},
                        new ClientesDetalle { NombreCliDetalle = "Berenice", TipoCliente="Excelente", DetalleCliente = "Siempre paga a tipo"},
                        new ClientesDetalle { NombreCliDetalle = "Carlos", TipoCliente="Malo", DetalleCliente = "Nunca paga"}
                    };
                    ClientesDetalleiniciales = new Dictionary<string, ClientesDetalle>();

                    foreach(ClientesDetalle catclinini in listadoClientes)
                    {
                        ClientesDetalleiniciales.Add(catclinini.TipoCliente, catclinini);
                    }//fin del foreach
                }
                return ClientesDetalleiniciales;
            }//fin del metodo get
        }//fin de diccionario de categorias
    }
}
