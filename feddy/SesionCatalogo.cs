using System;
using System.Collections.Generic;
using System.Text;

namespace feddy
{
    internal class SesionCatalogo
    {
        private static CatalogoPizzas catalogo = new CatalogoPizzas();

        public static CatalogoPizzas GetCatalogo()
        {
            return catalogo;
        }
    }
}
