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

            for (int i = 0; i < productos.Count; i++)
            {
                int indice = i;
                Producto producto = productos[i];

                Panel panelProducto = new Panel();
                panelProducto.Width = flpProductos.Width - 30;
                panelProducto.Height = 45;
                panelProducto.Margin = new Padding(5);

                Label lblProducto = new Label();
                lblProducto.Text = producto.GetNombre() +
                                   " - $" + producto.CalcularPrecio().ToString("0.00");
                lblProducto.AutoSize = true;
                lblProducto.Location = new Point(5, 12);
                lblProducto.Font = new Font("Arial", 11, FontStyle.Bold);

                Button btnEliminar = new Button();
                btnEliminar.Text = "Eliminar";
                btnEliminar.Size = new Size(85, 30);
                btnEliminar.Location = new Point(panelProducto.Width - 95, 5);

                btnEliminar.Click += (sender, e) =>
                {
                    gestorCarrito.EliminarProducto(indice);
                    MostrarProductos();
                };

                panelProducto.Controls.Add(lblProducto);
                panelProducto.Controls.Add(btnEliminar);

                flpProductos.Controls.Add(panelProducto);
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

        private void lablTotalTexto_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
