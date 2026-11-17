using System;
using System.Collections.Generic;
using System.Text;

namespace feddy
{
    //absoluto placeholder; no hace nada ni cumple ninguna función
    //remanente de cuando el proyecto era de 4 personas
    internal abstract class Producto
    {
        private int idProducto;
        private string nombre;
        private string descripcion;
        private decimal precioBase;

        protected Producto(int idProducto, string nombre, string descripcion, decimal precioBase)
        {
            this.idProducto = idProducto;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.precioBase = precioBase;
        }

        public int GetIdProducto()
        {
            return idProducto;
        }

        public void SetIdProducto(int idProducto)
        {
            this.idProducto = idProducto;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string GetDescripcion()
        {
            return descripcion;
        }

        public void SetDescripcion(string descripcion)
        {
            this.descripcion = descripcion;
        }

        public decimal GetPrecioBase()
        {
            return precioBase;
        }

        public void SetPrecioBase(decimal precioBase)
        {
            this.precioBase = precioBase;
        }

        public abstract decimal CalcularPrecio();


    }
}
