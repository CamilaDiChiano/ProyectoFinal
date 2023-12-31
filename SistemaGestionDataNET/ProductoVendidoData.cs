﻿using SistemaGestionBussiness;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clientData
{
    public class ProductoVendidoData
    {
        public static ProductoVendido ObtenerProductoVendido(int id)
        {
            try
            {
                using (var context = new SistemaGestionContext())
                {
                    return context.ProductosVendidos.FirstOrDefault(x => x.Id == id);

                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error al obtener el producto: " + ex.Message);

                return null;
            }

        }

        public static List<ProductoVendido> ListarProductoVendido()
        {
            try
            {
                using (var context = new SistemaGestionContext())
                {
                    return context.ProductosVendidos.ToList();
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error al obtener el producto: " + ex.Message);

                return null;
            }

        }

        public static void CrearProductoVendido(ProductoVendido productoVendido)
        {
            try
            {
                using (var context = new SistemaGestionContext())
                {
                    context.ProductosVendidos.Add(productoVendido);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error al obtener el producto: " + ex.Message);

                return;
            }


        }

        public static void EliminarProductoVendido(int id)
        {
            try
            {
                using (var context = new SistemaGestionContext())
                {
                    var productoVendidoExistente = context.ProductosVendidos.FirstOrDefault(x => x.Id == id);
                    if (productoVendidoExistente == null)
                    {
                        context.ProductosVendidos.Remove(productoVendidoExistente);
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
        public static void ModificarProductoVendido(ProductoVendido productoVendidoModificado)
        {
            try
            {
                using (var context = new SistemaGestionContext())
                {
                    var productoVendidoExistente = context.ProductosVendidos.FirstOrDefault(x => x.Id == productoVendidoModificado.Id);
                    if (productoVendidoExistente == null)
                    {
                        productoVendidoExistente.Id = productoVendidoModificado.Id;
                        productoVendidoExistente.IdProducto = productoVendidoModificado.IdProducto;
                        productoVendidoExistente.Stock = productoVendidoModificado.Stock;
                        productoVendidoExistente.IdVenta = productoVendidoModificado.IdVenta;

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