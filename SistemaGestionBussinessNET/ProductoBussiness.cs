﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionData;
using SistemaGestionEntities;

namespace SistemaGestionBussiness
{
    public class ProductoBussiness
    {
       

        public static void EliminarProducto(int id)
        {
            ProductoData.EliminarProducto(id);
        }

        public static void ModificarProducto(Producto productoModificado)
        {
            ProductoData.ModificarProducto(productoModificado);
        }

        public static Producto ObtenerProducto(int id)
        {
            return ProductoData.ObtenerProducto(id);
        }


    }
}
