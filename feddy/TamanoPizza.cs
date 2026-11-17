using System;
using System.Collections.Generic;
using System.Text;

namespace feddy
{
    internal class TamanoPizza
    {
        private int idTamano;
        private string nombre;
        private decimal precioBase;

        public TamanoPizza(int idTamano, string nombre, decimal precioBase)
        {
            this.idTamano = idTamano;
            this.nombre = nombre;

            if (precioBase >= 0)
            {
                this.precioBase = precioBase;
            }
        }

        public int GetIdTamano()
        {
            return idTamano;
        }

        public void SetIdTamano(int idTamano)
        {
            this.idTamano = idTamano;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public decimal GetPrecioBase()
        {
            return precioBase;
        }

        public void SetPrecioBase(decimal precioBase)
        {
            if (precioBase >= 0)
            {
                this.precioBase = precioBase;
            }
        }
    }
}
