using System;
using System.Collections.Generic;
using System.Text;

namespace feddy
{
    internal class Ingrediente
    {
        private int idIngrediente;
        private string nombre;
        private decimal precio;
        private bool disponible;

        public Ingrediente(int idIngrediente, string nombre, decimal precio, bool disponible)
        {
            this.idIngrediente = idIngrediente;
            this.nombre = nombre;
            this.precio = precio;
            this.disponible = disponible;
        }

        public int GetIdIngrediente()
        {
            return idIngrediente;
        }

        public void SetIdIngrediente(int idIngrediente)
        {
            this.idIngrediente = idIngrediente;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public decimal GetPrecio()
        {
            return precio;
        }

        public void SetPrecio(decimal precio)
        {
            if (precio >= 0)
            {
                this.precio = precio;
            }
        }

        public bool GetDisponible()
        {
            return disponible;
        }

        public void SetDisponible(bool disponible)
        {
            this.disponible = disponible;
        }
    }
}
