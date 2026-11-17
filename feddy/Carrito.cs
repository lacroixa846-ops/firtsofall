using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace feddy
{
    //El carrito: aqui deberia almacenarse los precios de cada producto y topping y mostrarlo al usuario
    //El label sigue siendo independiente todavia hay que hacerlo jalar
    public partial class Carrito : Form
    {
        private Carriton gestorCarrito;
        public Carrito()
        {
            InitializeComponent();
            gestorCarrito = SesionPedido.GetCarrito();
        }


        private void MostrarProductos()
        {
            flpProductos.Controls.Clear();

            List<Producto> productos = gestorCarrito.GetProductos();

            foreach (Producto producto in productos)
            {
                Label lblProducto = new Label();

                lblProducto.Text = producto.GetNombre() +
                                   " - $" + producto.CalcularPrecio().ToString("0.00");

                lblProducto.AutoSize = true;
                lblProducto.Font = new Font("Arial", 11, FontStyle.Bold);
                lblProducto.Margin = new Padding(10);

                flpProductos.Controls.Add(lblProducto);
            }

            lblTotal.Text = "$" + gestorCarrito.CalcularSubtotal().ToString("0.00");
        }

        internal void AgregarProducto(Producto producto)
        {
            gestorCarrito.AgregarProducto(producto);
            MostrarProductos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (gestorCarrito.GetProductos().Count == 0)
            {
                MessageBox.Show("Tu carrito está vacío.");
                return;
            }

            FrmPago ventanaPago = new FrmPago();
            ventanaPago.Show();

            this.Hide();
        }

        private void Carrito_Load(object sender, EventArgs e)
        {
            MostrarProductos();
        }
    }
}
