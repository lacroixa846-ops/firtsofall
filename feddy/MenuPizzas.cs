using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace feddy
{
    public partial class MenuPizzas : Form
    {
        private CatalogoPizzas catalogo;

        public MenuPizzas()
        {
            InitializeComponent();

            catalogo = SesionCatalogo.GetCatalogo();

            btnPepperoni.Click += btnPepperoni_Click;
            btnQueso.Click += btnQueso_Click;
            btnTresCarnes.Click += btnTresCarnes_Click;
            btnHawaiana.Click += btnHawaiana_Click;
            btnOrillaRellena.Click += btnOrillaRellena_Click;
            btnCarrito.Click += btnCarrito_Click;

            PrepararDiseno();
            CrearEncabezado();
            CrearMenuPizzas();
            CrearBotonCarrito();
        }
        private void CrearEncabezado()
        {
            Panel encabezado = new Panel();
            encabezado.Size = new Size(550, 90);
            encabezado.Location = new Point(0, 0);
            encabezado.BackColor = Color.FromArgb(245, 105, 20);

            Panel franja = new Panel();
            franja.Size = new Size(550, 5);
            franja.Location = new Point(0, 85);
            franja.BackColor = Color.FromArgb(255, 190, 35);

            Label titulo = new Label();
            titulo.Text = "FEDDY PIZZERÍA";
            titulo.Font = new Font("Arial", 21, FontStyle.Bold);
            titulo.ForeColor = Color.White;
            titulo.AutoSize = true;
            titulo.Location = new Point(18, 9);

            Label subtitulo = new Label();
            subtitulo.Text = "¡LAS FAVORITAS DE TODOS!";
            subtitulo.Font = new Font("Arial", 9, FontStyle.Bold);
            subtitulo.ForeColor = Color.FromArgb(255, 239, 190);
            subtitulo.AutoSize = true;
            subtitulo.Location = new Point(21, 46);

            encabezado.Controls.Add(titulo);
            encabezado.Controls.Add(subtitulo);
            encabezado.Controls.Add(franja);

            this.Controls.Add(encabezado);
            encabezado.BringToFront();
        }
        private void PrepararDiseno()
        {
            foreach (Control control in this.Controls)
            {
                control.Visible = false;
            }

            this.Text = "Feddy - Menú de pizzas";
            this.ClientSize = new Size(560, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(255, 248, 235);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }
        private void CrearMenuPizzas()
        {
            FlowLayoutPanel contenedor = new FlowLayoutPanel();

            contenedor.Location = new Point(10, 100);
            contenedor.Size = new Size(530, 420);
            contenedor.AutoScroll = true;
            contenedor.FlowDirection = FlowDirection.TopDown;
            contenedor.WrapContents = false;
            contenedor.Padding = new Padding(0);
            contenedor.BackColor = Color.FromArgb(255, 248, 235);

            this.Controls.Add(contenedor);

            CrearTarjeta(contenedor, "Pepperoni", "$99", "pizza_pepperoni_nueva.png",
                () => AgregarPizza(catalogo.GetPepperoni()));

            CrearTarjeta(contenedor, "Queso", "$89", "pizza_queso.png",
                () => AgregarPizza(catalogo.GetQueso()));

            CrearTarjeta(contenedor, "Tres Carnes", "$189", "pizza_tres_carnes_nueva.png",
                () => AgregarPizza(catalogo.GetTresCarnes()));

            CrearTarjeta(contenedor, "Hawaiana", "$189", "pizza_hawaiana.png",
                () => AgregarPizza(catalogo.GetHawaiana()));

            CrearTarjeta(contenedor, "Orilla Rellena", "$189", "pizza-orilla_rellena.png",
                () => AgregarPizza(catalogo.GetOrillaRellena()));
        }
        private void CrearBotonCarrito()
        {
            Button btnCarritoNuevo = new Button();

            btnCarritoNuevo.Text = "VER MI CARRITO";
            btnCarritoNuevo.Size = new Size(530, 45);
            btnCarritoNuevo.Location = new Point(10, 540);

            btnCarritoNuevo.BackColor = Color.FromArgb(245, 115, 35);
            btnCarritoNuevo.ForeColor = Color.White;

            btnCarritoNuevo.Font = new Font("Arial", 11, FontStyle.Bold);
            btnCarritoNuevo.FlatStyle = FlatStyle.Flat;
            btnCarritoNuevo.FlatAppearance.BorderSize = 0;

            btnCarritoNuevo.Click += (sender, e) =>
            {
                Carrito ventana = new Carrito();
                ventana.Show();
            };

            this.Controls.Add(btnCarritoNuevo);
            btnCarritoNuevo.BringToFront();
        }
        private void CrearTarjeta(FlowLayoutPanel contenedor, string nombre,
            string precio, string imagen, Action agregar)
        {
            Panel tarjeta = new Panel();
            tarjeta.Size = new Size(510, 115);
            tarjeta.BackColor = Color.White;
            tarjeta.Margin = new Padding(2, 3, 2, 7);

            PictureBox foto = new PictureBox();
            foto.Size = new Size(105, 105);
            foto.Location = new Point(5, 5);
            foto.SizeMode = PictureBoxSizeMode.Zoom;

            string ruta = Application.StartupPath + @"\Imagenes\" + imagen;

            if (System.IO.File.Exists(ruta))
            {
                try
                {
                    using (Image original = Image.FromFile(ruta))
                    {
                        foto.Image = new Bitmap(original);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error al cargar: " + imagen + "\n" + ex.Message
                    );
                }
            }
            else
            {
                MessageBox.Show("No se encontró: " + ruta);
            }

            Label lblNombre = new Label();
            lblNombre.Text = nombre;
            lblNombre.Location = new Point(125, 20);
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Arial", 11, FontStyle.Bold);
            lblNombre.ForeColor = Color.FromArgb(45, 45, 45);

            Label lblPrecio = new Label();
            lblPrecio.Text = precio;
            lblPrecio.Location = new Point(125, 52);
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Arial", 10, FontStyle.Bold);
            lblPrecio.ForeColor = Color.FromArgb(210, 65, 30);

            Button btnAgregar = new Button();
            btnAgregar.Text = "AGREGAR";
            btnAgregar.Location = new Point(390, 38);
            btnAgregar.Size = new Size(105, 38);
            btnAgregar.BackColor = Color.FromArgb(245, 115, 35);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.Font = new Font("Arial", 8, FontStyle.Bold);
            btnAgregar.Click += (sender, e) => agregar();

            tarjeta.Controls.Add(foto);
            tarjeta.Controls.Add(lblNombre);
            tarjeta.Controls.Add(lblPrecio);
            tarjeta.Controls.Add(btnAgregar);

            contenedor.Controls.Add(tarjeta);
        }

        private void MenuPizzas_Load(object sender, EventArgs e)
        {

        }

        private void AgregarPizza(Pizza pizza)
        {
            if (pizza == null)
            {
                return;
            }

            SesionPedido.GetCarrito().AgregarProducto(pizza);

            MessageBox.Show(
                pizza.GetNombre() + " agregada al carrito.",
                "Producto agregado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnPepperoni_Click(object sender, EventArgs e)
        {
            AgregarPizza(catalogo.GetPepperoni());
        }

        private void btnQueso_Click(object sender, EventArgs e)
        {
            AgregarPizza(catalogo.GetQueso());
        }

        private void btnTresCarnes_Click(object sender, EventArgs e)
        {
            AgregarPizza(catalogo.GetTresCarnes());
        }

        private void btnHawaiana_Click(object sender, EventArgs e)
        {
            AgregarPizza(catalogo.GetHawaiana());
        }

        private void btnOrillaRellena_Click(object sender, EventArgs e)
        {
            AgregarPizza(catalogo.GetOrillaRellena());
        }

        private void btnCarrito_Click(object sender, EventArgs e)
        {
            Carrito ventana = new Carrito();
            ventana.Show();
        }
    }
}
