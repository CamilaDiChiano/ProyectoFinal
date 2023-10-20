using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionData;
using SistemaGestionEntities;
using Microsoft.EntityFrameworkCore;
using clientData;
using SistemaGestionBussiness;

namespace SistemaGestionEntities
{
    public static class ProductoData
    {
        public static Producto ObtenerProducto(int id)
        {
            try
            {
                using (var context = new SistemaGestionContext())
                {
                   
                    return context.Productos.FirstOrDefault(p => p.Id == id);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error al obtener el producto: " + ex.Message);

                return null;
            }

        }
       

        public static void CrearProducto(Producto producto)
        {
            try
            {
                using (var context = new SistemaGestionContext())
                {
                    context.Productos.Add(producto);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error al obtener el producto: " + ex.Message);

                return;
            }


        }

        public static void EliminarProducto(int id)
        {
            try
            {
                using (var context = new SistemaGestionContext())
                {
                    var productoExistente = context.Productos.FirstOrDefault(p => p.Id == id);
                    if (productoExistente != null)
                    {
                        context.Productos.Remove(productoExistente);
                        context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error al obtener el producto: " + ex.Message);

                return;
            }


        }

        public static void ModificarProducto(Producto productoModificado)
        {
            try
            {
                using (var context = new SistemaGestionContext())
                {
                    var productoExistente = context.Productos.FirstOrDefault(p => p.Id == productoModificado.Id);
                    if (productoExistente != null)
                    {
                        productoExistente.Descripcion = productoModificado.Descripcion;
                        productoExistente.Costo = productoModificado.Costo;
                        productoExistente.PrecioVenta = productoModificado.PrecioVenta;
                        productoExistente.Stock = productoModificado.Stock;
                        productoExistente.Id = productoModificado.Id;
                        context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error al obtener el producto: " + ex.Message);

                return;
            }

        }
    }
}
