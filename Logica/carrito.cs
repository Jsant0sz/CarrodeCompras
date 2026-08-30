using System;
using System.Collections.Generic;

namespace Carrito.Logica
{
    // Clase auxiliar para que el código compile correctamente
    public class Producto
    {
        public bool VerificarStock(int cantidad)
        {
            // Lógica para verificar stock
            return true; 
        }
    }

    public class Detalle
    {
        public int Cantidad { get; set; }
        public Producto Producto { get; set; }

        public Detalle(int cantidad, Producto producto)
        {
            Cantidad = cantidad;
            Producto = producto;
        }

        public void MostrarDetalle()
        {
            Console.WriteLine($"Cantidad: {Cantidad}");
        }
    }

    public class Carrito
    {
        // Propiedad para la lista de detalles
        public List<Detalle> LstDetalle { get; set; }

        // Constructor
        public Carrito()
        {
            LstDetalle = new List<Detalle>();
        }

        // Método para agregar producto (retorna bool)
        public bool AgregarProducto(int intCantidad, Producto objProducto)
        {
            // Validación de stock
            if (!objProducto.VerificarStock(intCantidad))
            {
                Console.WriteLine("No hay stock");
                return false;
            }

            // Se agrega el detalle a la lista si hay stock
            LstDetalle.Add(new Detalle(intCantidad, objProducto));
            return true;
        }

        // Método para procesar o listar el carrito
        public void VerCarrito()
        {
            if (LstDetalle.Count == 0)
            {
                Console.WriteLine("El carrito está vacío.");
                return;
            }

            foreach (var item in LstDetalle)
            {
                item.MostrarDetalle();
            }
        }
    }
}