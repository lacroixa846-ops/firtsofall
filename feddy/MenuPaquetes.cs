using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace feddy
{
    public partial class MenuPaquetes : Form
    {
        public MenuPaquetes()
        {
            InitializeComponent();
        }

        private void AgregarPaquete(int id, string nombre, string descripcion, decimal precio)
        {
            Complemento paquete = new Complemento(
                id,
                nombre,
                descripcion,
                precio,
                "Paquete"
            );

            SesionPedido.GetCarrito().AgregarProducto(paquete);

            MessageBox.Show(nombre + " agregado al carrito.");
        }

        private void btnPaquete1_Click(object sender, EventArgs e)
        {
            AgregarPaquete(
                101,
                "Paquete individual",
                "Pizza personal, refresco individual y papas pequeñas",
                119.00m
            );
        }

        private void btnPaquete2_Click(object sender, EventArgs e)
        {
            AgregarPaquete(
                102,
                "Paquete especial",
                "Pizza mediana, dos refrescos individuales y pan de ajo",
                219.00m
            );
        }

        private void btnPaquete3_Click(object sender, EventArgs e)
        {
            AgregarPaquete(
                103,
                "Paquete familiar",
                "Dos pizzas grandes, alitas, papas y cuatro refrescos",
                349.00m
            );
        }

        private void btnCarrito_Click(object sender, EventArgs e)
        {
            Carrito ventana = new Carrito();
            ventana.Show();
        }

        private void MenuPaquetes_Load(object sender, EventArgs e)
        {
        }
    }
}
