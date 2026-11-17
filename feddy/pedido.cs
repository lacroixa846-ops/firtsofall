using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace feddy
{
    public partial class pedido : Form
    {
        public pedido()
        {
            InitializeComponent();
        }

        private void pedido_Load(object sender, EventArgs e)
        {

            Conexion conexion = new Conexion();
            conexion.ProbarConexion();
            try
            {
                SoundPlayer reproductor = new SoundPlayer(@"C:\Users\sanch\source\repos\feddy\feddy\Resources\gato riendo.wav");
                reproductor.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("acabron: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Tuneo_de_Pizza ventana = new Tuneo_de_Pizza();
            ventana.Show();
        }

        private void btnCarrito_Click(object sender, EventArgs e)
        {
            Carrito ventana = new Carrito();
            ventana.Show();
        }

    }
}
