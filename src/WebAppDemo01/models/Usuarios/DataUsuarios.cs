using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace WebAppDemo01.models
{
    public static class DataUsuarios
    {
        
        public static void AgregarData(IApplicationBuilder ab)
        {
            AppDbContext contexto = ab.ApplicationServices.GetRequiredService<AppDbContext>();

            if (!contexto.CategoriasUsuarios.Any())
            {
                //CategoriasProductosIniciales es una coleccion local
                contexto.CategoriasUsuarios.AddRange(CategoriasUsuariosIniciales.Select(c => c.Value));
            }
            if (!contexto.Usuarios.Any())
            {
                contexto.AddRange
                (
                    new Usuarios { NombreUsuario = "Juan Pedro", ApellidoUsuario = "Melgar Ramirez", UserName = "JuanMelgar", Contraseña = "123", fechacreacion = "30/05/2018", UsuariosInactivos = true, ListaNegra = false, ImagenUsuarioURL = "/Imagenes/Usuarios/01.jpg", CatUsuarios = CategoriasUsuariosIniciales["Departamento de Tecnologia"] },
                    new Usuarios { NombreUsuario = "Josue Raul", ApellidoUsuario = "Calero Perez", UserName = "RaulCalero", Contraseña = "123", fechacreacion = "30/05/2018", UsuariosInactivos = false, ListaNegra = false, ImagenUsuarioURL = "/Imagenes/Usuarios/02.jpg", CatUsuarios = CategoriasUsuariosIniciales["Departamento de Ventas"] },
                    new Usuarios { NombreUsuario = "Juan Alfonso", ApellidoUsuario = "Melgar Alas", UserName = "AlfonsoAlas", Contraseña = "123", fechacreacion = "30/05/2018", UsuariosInactivos = true, ListaNegra = false, ImagenUsuarioURL = "/Imagenes/Usuarios/03.jpg", CatUsuarios = CategoriasUsuariosIniciales["Departamento de Ventas"] },
                    new Usuarios { NombreUsuario = "Carlos Alfonso", ApellidoUsuario = "Del Rio, Mendez", UserName = "CarlosMendez", Contraseña = "123", fechacreacion = "30/05/2018", UsuariosInactivos = true, ListaNegra = false, ImagenUsuarioURL = "/Imagenes/Usuarios/04.jpg", CatUsuarios = CategoriasUsuariosIniciales["Departamento de Tecnologia"] },
                    new Usuarios { NombreUsuario = "Katleen Jazmin", ApellidoUsuario = "Machado Leiva", UserName = "JaminLeiva", Contraseña = "123", fechacreacion = "30/05/2018", UsuariosInactivos = false, ListaNegra = false, ImagenUsuarioURL = "/Imagenes/Usuarios/05.jpg", CatUsuarios = CategoriasUsuariosIniciales["Departamento de Logistica"] },
                    new Usuarios { NombreUsuario = "Benito Bonny", ApellidoUsuario = "Calero Perez", UserName = "BadBonnyCalero", Contraseña = "123", fechacreacion = "30/05/2018", UsuariosInactivos = false, ListaNegra = true, ImagenUsuarioURL = "/Imagenes/Usuarios/06.jpg", CatUsuarios = CategoriasUsuariosIniciales["Departamento de Logistica"] }



                );
            }

            contexto.SaveChanges();
        }//fin de agregarData

        //se hace referencia a la clase dominio CatProductos
        public static Dictionary<string, CatUsuarios> catUsuariosiniciales;
        public static Dictionary<string, CatUsuarios> CategoriasUsuariosIniciales
        {
            get
            {
                if(catUsuariosiniciales == null)
                {
                    var listadoCategorias = new CatUsuarios[]
                    {
                        new CatUsuarios { NombreCatUo = "Departamento de Tecnologia", DescripcionCatUo ="Encargados de revisar producto relacionado a electronica"},
                        new CatUsuarios { NombreCatUo = "Departamento de Ventas", DescripcionCatUo="Personal para ventas"},
                        new CatUsuarios { NombreCatUo = "Departamento de Logistica", DescripcionCatUo="Creacion de estrategias publicitaria para agilizar las ventas"},
                    };
                    catUsuariosiniciales = new Dictionary<string, CatUsuarios>();

                    foreach(CatUsuarios catproini in listadoCategorias)
                    {
                        catUsuariosiniciales.Add(catproini.NombreCatUo, catproini);
                    }//fin del foreach
                }
                return catUsuariosiniciales;
            }//fin del metodo get
        }//fin de diccionario de categorias
    }
}
