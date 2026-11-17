using System;
using System.Collections.Generic;
using System.Text;

namespace feddy
{
    internal class SesionPedido
    {
        private static Carriton carrito = new Carriton();

        public static Carriton GetCarrito()
        {
            return carrito;
        }
    }
}
