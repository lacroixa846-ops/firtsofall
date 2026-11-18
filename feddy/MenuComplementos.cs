using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace feddy
{
    public partial class MenuComplementos : Form
    {
        public MenuComplementos()
        {
            InitializeComponent();
        }

        private void AgregarComplemento(int id, string nombre, string descripcion, decimal precio, string tipo)
        {
            Complemento complemento = new Complemento(
                id,
                nombre,
                descripcion,
                precio,
                tipo
            );

            SesionPedido.GetCarrito().AgregarProducto(complemento);

            MessageBox.Show(nombre + " agregado al carrito.");
        }

        private void btnRefresco_Click(object sender, EventArgs e)
        {
            AgregarComplemento(1, "Refresco", "Refresco individual", 25.00m, "Bebida");
        }

        private void btnPapas_Click(object sender, EventArgs e)
        {
            AgregarComplemento(2, "Papas", "Orden de papas", 35.00m, "Acompañamiento");
        }

        private void btnAlitas_Click(object sender, EventArgs e)
        {
            AgregarComplemento(3, "Alitas", "Orden de alitas", 75.00m, "Acompañamiento");
        }

        private void btnPanAjo_Click(object sender, EventArgs e)
        {
            AgregarComplemento(4, "Pan de ajo", "Orden de pan de ajo", 30.00m, "Acompañamiento");
        }

        private void btnCarrito_Click(object sender, EventArgs e)
        {
            Carrito ventana = new Carrito();
            ventana.Show();
        }
        private void MenuComplementos_Load(object sender, EventArgs e)
        {
        }
    }
}
