using System;
using System.Collections.Generic;
using System.Text;

namespace feddy
{
    //absoluto placeholder; no hace nada ni cumple ninguna función
    //remanente de cuando el proyecto era de 4 personas
    internal class Pizza : Producto
    {
        private bool esPersonalizada;
        private bool orillaQueso;
        private List<Ingrediente> ingredientes;
        private int porcionesQueso;
        private string salsa;
        private string estilo;
        private bool chileSeco;
        private TamanoPizza tamano;
        public Pizza(
            int idProducto,
            string nombre,
            string descripcion,
            decimal precioBase,
            bool esPersonalizada,
            bool orillaQueso,
            int porcionesQueso,
            string salsa,
            string estilo,
            bool chileSeco,
            TamanoPizza tamano

             ) : base(idProducto, nombre, descripcion, precioBase)
        {
            this.esPersonalizada = esPersonalizada;
            this.orillaQueso = orillaQueso;
            this.ingredientes = new List<Ingrediente>();
            this.porcionesQueso = porcionesQueso;
            this.salsa = salsa;
            this.estilo = estilo;
            this.chileSeco = chileSeco;

            if (tamano != null && (esPersonalizada || tamano.GetNombre() == "Grande"))
            {
                this.tamano = tamano;
            }
            else
            {
                this.tamano = null;
            }
        }

        public bool GetOrillaQueso()
        {
            return orillaQueso;
        }

        public void SetOrillaQueso(bool orillaQueso)
        {
            if (esPersonalizada)
            {
                this.orillaQueso = orillaQueso;
            }
        }
        public bool GetEsPersonalizada()
        {
            return esPersonalizada;
        }

        public void SetEsPersonalizada(bool esPersonalizada)
        {
            // La modalidad se define al crear la pizza.
        }
        public int GetPorcionesQueso()
        {
            return porcionesQueso;
        }

        public void SetPorcionesQueso(int porcionesQueso)
        {
            if (porcionesQueso == 1 || porcionesQueso == 2)
            {
                this.porcionesQueso = porcionesQueso;
            }
        }
        private decimal CalcularPrecioQueso()
        {
            if (esPersonalizada && porcionesQueso == 2)
            {
                return 15m;
            }

            return 0m;
        }

        public List<Ingrediente> GetIngredientes()
        {
            return new List<Ingrediente>(ingredientes);
        }

        public void AgregarIngrediente(Ingrediente ingrediente)
        {
            if (esPersonalizada && ingrediente != null && ingrediente.GetDisponible())
            {
                ingredientes.Add(ingrediente);
            }
        }

        public void QuitarIngrediente(Ingrediente ingrediente)
        {
            if (esPersonalizada && ingrediente != null)
            {
                ingredientes.Remove(ingrediente);
            }
        }

        public string GetSalsa()
        {
            return salsa;
        }

        public void SetSalsa(string salsa)
        {
            if (salsa == "Normal" || salsa == "Extra" || salsa == "Doble")
            {
                this.salsa = salsa;
            }
        }
        private decimal CalcularPrecioSalsa()
        {
            if (!esPersonalizada)
            {
                return 0m;
            }

            if (salsa == "Extra")
            {
                return 5m;
            }

            if (salsa == "Doble")
            {
                return 10m;
            }

            return 0m;
        }
        private decimal CalcularPrecioOrilla()
        {
            if (esPersonalizada && orillaQueso)
            {
                return 30m;
            }

            return 0m;
        }
        public string GetEstilo()
        {
            return estilo;
        }

        public void SetEstilo(string estilo)
        {
            this.estilo = estilo;
        }

        public bool GetChileSeco()
        {
            return chileSeco;
        }

        public void SetChileSeco(bool chileSeco)
        {
            this.chileSeco = chileSeco;
        }

        public TamanoPizza GetTamano()
        {
            return tamano;
        }

        public void SetTamano(TamanoPizza tamano)
        {
            if (tamano != null && (esPersonalizada || tamano.GetNombre() == "Grande"))
            {
                this.tamano = tamano;
            }
        }

        public override decimal CalcularPrecio()
        {
            decimal total = GetPrecioBase();

            if (!esPersonalizada)
            {
                return total;
            }

            total += CalcularPrecioQueso();
            total += CalcularPrecioSalsa();
            total += CalcularPrecioOrilla();

            foreach (Ingrediente ingrediente in ingredientes)
            {
                total += ingrediente.GetPrecio();
            }

            return total;
        }
    }
}
