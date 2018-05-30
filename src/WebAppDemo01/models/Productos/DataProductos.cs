using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace WebAppDemo01.models
{
    public static class DataProductos
    {
        
        public static void AgregarData(IApplicationBuilder ab)
        {
            AppDbContext contexto = ab.ApplicationServices.GetRequiredService<AppDbContext>();

            if (!contexto.CategoriasProductos.Any())
            {
                //CategoriasProductosIniciales es una coleccion local
                contexto.CategoriasProductos.AddRange(CategoriasProductosIniciales.Select(c => c.Value));
            }
            if (!contexto.Productos.Any())
            {
                contexto.AddRange
                (
                    new Productos { NombreProducto = "Huawei p20 Pro", DescripProducto="Telefono Androi Alta Gama", PreCostoProducto = 600.0M, PreVentaProducto = 750.0M, ImagenURL = "/Imagenes/productos/HUAWEIP20.jpg", ProductoEnOferta = true, ProductoEnExistencia = true, EstadoProducto = true, CatProductos = CategoriasProductosIniciales["Telefonos"]},
                    new Productos { NombreProducto = "Laptop HP", DescripProducto = "Computadora portil", PreCostoProducto = 600.0M, PreVentaProducto = 850.0M, ImagenURL = "/Imagenes/productos/LAPTOPHP.jpg", ProductoEnOferta = false, ProductoEnExistencia = true, EstadoProducto = true, CatProductos = CategoriasProductosIniciales["Computadoras"] },
                    new Productos { NombreProducto = "PlayStation PRO", DescripProducto = "Cosola de videojuegos", PreCostoProducto = 350.0M, PreVentaProducto = 500.0M, ImagenURL = "/Imagenes/productos/PSPRO.jpg", ProductoEnOferta = true, ProductoEnExistencia = true, EstadoProducto = true, CatProductos = CategoriasProductosIniciales["Consolas"] },
                    new Productos { NombreProducto = "LG 4K", DescripProducto = "Television LG 49 pulgadas", PreCostoProducto = 400.0M, PreVentaProducto = 900.0M, ImagenURL = "/Imagenes/productos/LG.jpg", ProductoEnOferta = true, ProductoEnExistencia = true, EstadoProducto = true, CatProductos = CategoriasProductosIniciales["TV"] },
                    new Productos { NombreProducto = "Sillón Reclinable", DescripProducto = "Sillón individual reclinable mecedora negro", PreCostoProducto = 90.0M, PreVentaProducto = 299.0M, ImagenURL = "/Imagenes/productos/MUEBLE.jpg", ProductoEnOferta = true, ProductoEnExistencia = true, EstadoProducto = true, CatProductos = CategoriasProductosIniciales["Muebles"] },
                    new Productos { NombreProducto = "Batidora Pajarito", DescripProducto = "Batidora Mini Artisan 3.5 litros", PreCostoProducto = 100.0M, PreVentaProducto = 339.9M, ImagenURL = "/Imagenes/productos/BATIDORA.jpg", ProductoEnOferta = true, ProductoEnExistencia = true, EstadoProducto = true, CatProductos = CategoriasProductosIniciales["Electrodomesticos"] },
                    new Productos { NombreProducto = "Microondas Panasonic", DescripProducto = "Microondas 2.2 pies de 1200w ", PreCostoProducto = 100.0M, PreVentaProducto = 219.0M, ImagenURL = "/Imagenes/productos/MICROONDAS.jpg", ProductoEnOferta = true, ProductoEnExistencia = true, EstadoProducto = true, CatProductos = CategoriasProductosIniciales["Electrodomesticos"] },
                    new Productos { NombreProducto = "Cafetera Oster", DescripProducto = "Cafetera 4 tazas", PreCostoProducto = 25.0M, PreVentaProducto = 34.90M, ImagenURL = "/Imagenes/productos/MICROONDAS.jpg", ProductoEnOferta = true, ProductoEnExistencia = true, EstadoProducto = true, CatProductos = CategoriasProductosIniciales["Electrodomesticos"] },
                    new Productos { NombreProducto = "Comedor", DescripProducto = "Comedor 6 personas rectangular", PreCostoProducto = 319.0M, PreVentaProducto = 631.99M, ImagenURL = "/Imagenes/productos/COMEDOR.jpg", ProductoEnOferta = true, ProductoEnExistencia = true, EstadoProducto = true, CatProductos = CategoriasProductosIniciales["Muebles"] },
                    new Productos { NombreProducto = "Cama King Koil", DescripProducto = "Cama matrimonial edición especial", PreCostoProducto = 100.0M, PreVentaProducto = 260.0M, ImagenURL = "/Imagenes/productos/MUEBLE.jpg", ProductoEnOferta = true, ProductoEnExistencia = true, EstadoProducto = true, CatProductos = CategoriasProductosIniciales["Muebles"] }
                );
            }

            contexto.SaveChanges();
        }//fin de agregarData

        //se hace referencia a la clase dominio CatProductos
        public static Dictionary<string, CatProductos> catproductosiniciales;
        public static Dictionary<string, CatProductos> CategoriasProductosIniciales
        {
            get
            {
                if(catproductosiniciales == null)
                {
                    var listadoCategorias = new CatProductos[]
                    {
                        new CatProductos { NombreCatProducto = "Telefonos" },
                        new CatProductos { NombreCatProducto = "Computadoras" },
                        new CatProductos { NombreCatProducto = "Consolas" },
                        new CatProductos { NombreCatProducto = "TV" },
                        new CatProductos { NombreCatProducto = "Muebles" },
                        new CatProductos { NombreCatProducto = "Electrodomesticos" },
                    };
                    catproductosiniciales = new Dictionary<string, CatProductos>();

                    foreach(CatProductos catproini in listadoCategorias)
                    {
                        catproductosiniciales.Add(catproini.NombreCatProducto, catproini);
                    }//fin del foreach
                }
                return catproductosiniciales;
            }//fin del metodo get
        }//fin de diccionario de categorias
    }
}
