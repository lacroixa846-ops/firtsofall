using System;
using System.Collections.Generic;
using System.Text;

namespace feddy
{
    internal class CatalogoPizzas
    {
        private TamanoPizza chico;
        private TamanoPizza mediano;
        private TamanoPizza grande;
        private Pizza pepperoni;
        private Pizza queso;
        private Pizza tresCarnes;
        private Pizza hawaiana;
        private Pizza orillaRellena;
        private List<Ingrediente> ingredientes;

        public CatalogoPizzas()
        {
            ingredientes = new List<Ingrediente>();
            chico = new TamanoPizza(1, "Chico", 70m);
            mediano = new TamanoPizza(2, "Mediano", 110m);
            grande = new TamanoPizza(3, "Grande", 140m);
            pepperoni = new Pizza(1, "Pepperoni", "Pizza clásica de pepperoni",
                99m, false, false, 1, "Normal", "", false, grande);
            queso = new Pizza(2, "Queso", "Pizza clásica de queso",
                89m, false, false, 1, "Normal", "", false, grande);
            tresCarnes = new Pizza(3, "3 Carnes", "Pizza clásica de tres carnes",
                189m, false, false, 1, "Normal", "", false, grande);
            hawaiana = new Pizza(4, "Hawaiana", "Pizza clásica hawaiana",
                189m, false, false, 1, "Normal", "", false, grande);
            orillaRellena = new Pizza(5, "Orilla Rellena", "Pizza clásica con orilla rellena de queso",
                189m, false, true, 1, "Normal", "", false, grande);
            AgregarIngrediente(new Ingrediente(1, "Jamón", 9m, true));
            AgregarIngrediente(new Ingrediente(2, "Aceituna negra", 9m, true));
            AgregarIngrediente(new Ingrediente(3, "Piña", 9m, true));
            AgregarIngrediente(new Ingrediente(4, "Morrón", 9m, true));
            AgregarIngrediente(new Ingrediente(5, "Cebolla", 9m, true));
            AgregarIngrediente(new Ingrediente(6, "Champiñón", 9m, true));
            AgregarIngrediente(new Ingrediente(7, "Salchicha italiana", 9m, true));
            AgregarIngrediente(new Ingrediente(8, "Tocino", 9m, true));
            AgregarIngrediente(new Ingrediente(9, "Jalapeños", 9m, true));
        }

        public TamanoPizza GetChico()
        {
            return chico;
        }

        public TamanoPizza GetMediano()
        {
            return mediano;
        }

        public TamanoPizza GetGrande()
        {
            return grande;
        }
        public Pizza GetPepperoni()
        {
            return pepperoni;
        }

        public Pizza GetQueso()
        {
            return queso;
        }

        public Pizza GetTresCarnes()
        {
            return tresCarnes;
        }

        public Pizza GetHawaiana()
        {
            return hawaiana;
        }

        public Pizza GetOrillaRellena()
        {
            return orillaRellena;
        }
        public void AgregarIngrediente(Ingrediente ingrediente)
        {
            if (ingrediente != null && ingrediente.GetDisponible())
            {
                ingredientes.Add(ingrediente);
            }
        }
        public List<Ingrediente> GetIngredientes()
        {
            return new List<Ingrediente>(ingredientes);
        }
        public Pizza CrearPizzaPersonalizada(
            string nombre,
            TamanoPizza tamano)
        {
            if (tamano == null)
            {
                return null;
            }

            return new Pizza(
                0,
                nombre,
                "Pizza personalizada",
                tamano.GetPrecioBase(),
                true,
                false,
                1,
                "Normal",
                "",
                false,
                tamano
            );
        }
    }
}
