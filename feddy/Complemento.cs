using System;
using System.Collections.Generic;
using System.Text;

namespace feddy
{
    internal class Complemento : Producto
    {
        private string tipo;

        public Complemento(
            int idProducto,
            string nombre,
            string descripcion,
            decimal precioBase,
            string tipo
            ) : base(idProducto, nombre, descripcion, precioBase)
        {
            this.tipo = tipo;
        }

        public string GetTipo()
        {
            return tipo;
        }

        public void SetTipo(string tipo)
        {
            this.tipo = tipo;
        }

        public override decimal CalcularPrecio()
        {
            return GetPrecioBase();
        }
    }
}
