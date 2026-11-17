using System;
using System.Collections.Generic;
using System.Text;

namespace feddy
{
    internal class Carriton
    {
        private List<Producto> productos;

        public Carriton()
        {
            productos = new List<Producto>();
        }

        public void AgregarProducto(Producto producto)
        {
            if (producto != null)
            {
                productos.Add(producto);
            }
        }

        public void EliminarProducto(int indice)
        {
            if (indice >= 0 && indice < productos.Count)
            {
                productos.RemoveAt(indice);
            }
        }

        public List<Producto> GetProductos()
        {
            return new List<Producto>(productos);
        }

        public decimal CalcularSubtotal()
        {
            decimal subtotal = 0;

            foreach (Producto producto in productos)
            {
                subtotal += producto.CalcularPrecio();
            }

            return subtotal;
        }

        public void VaciarCarrito()
        {
            productos.Clear();
        }
    }
}
