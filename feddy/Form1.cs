using System.Drawing.Text;
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace feddy
{
    //Esta es la pagina principal, te preguntas porqué todos los botones menos "NUESTRA HISTORIA hacen lo mismo?
    //No me preguntes a mi, preguntaselo al que hizo la pagina oficial! hacen exactamente lo mismo
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
            if (pizza == null)
            {
                return;
            }

            SesionPedido.GetCarrito().AgregarProducto(pizza);

            MessageBox.Show(
                pizza.GetNombre() + " agregada al carrito."
            );
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pedido ventanaNueva = new pedido();
            ventanaNueva.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Nuestra_historia ventanaNueva = new Nuestra_historia();
            ventanaNueva.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Carrito ventanaNueva = new Carrito();
            ventanaNueva.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pedido ventanaNueva = new pedido();
            ventanaNueva.Show();
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
    }
}
