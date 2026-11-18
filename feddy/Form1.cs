
using System;
using System.Windows.Forms;

namespace feddy
{
    public partial class Form1 : Form
    {
        private CatalogoPizzas catalogo;

        public Form1()
        {
            InitializeComponent();
            catalogo = SesionCatalogo.GetCatalogo();
        }

        private void AgregarPizzaClasica(Pizza pizza)
        {
            if (pizza == null) return;

            SesionPedido.GetCarrito().AgregarProducto(pizza);

            MessageBox.Show(pizza.GetNombre() + " agregada al carrito.");
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pedido ventana = new pedido();
            ventana.Show();
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void pictureBox2_Click(object sender, EventArgs e) { }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) { }

        private void panelHeader_Paint(object sender, PaintEventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Nuestra_historia().Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new Carrito().Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pedido ventana = new pedido();
            ventana.Show();
        }

        private void pictureBoxPepperoni_Click(object sender, EventArgs e)
        {
            AgregarPizzaClasica(catalogo.GetPepperoni());
        }

        private void pictureBoxQueso_Click(object sender, EventArgs e)
        {
            AgregarPizzaClasica(catalogo.GetQueso());
        }

        private void pictureBoxTresCarnes_Click(object sender, EventArgs e)
        {
            AgregarPizzaClasica(catalogo.GetTresCarnes());
        }

        private void pictureBoxHawaiana_Click(object sender, EventArgs e)
        {
            AgregarPizzaClasica(catalogo.GetHawaiana());
        }

        private void pictureBoxOrillaRellena_Click(object sender, EventArgs e)
        {
            AgregarPizzaClasica(catalogo.GetOrillaRellena());
        }

        private void pbPizzas_Click(object sender, EventArgs e)
        {
            pedido ventana = new pedido();
            ventana.Show();
        }

        private void pbCrearPizza_Click(object sender, EventArgs e)
        {
            pedido ventana = new pedido();
            ventana.Show();
        }
    }
}
