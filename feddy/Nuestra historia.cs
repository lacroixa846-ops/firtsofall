using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace feddy
{
    //Es emotiva no?
    public partial class Nuestra_historia : Form
    {
        public Nuestra_historia()
        {
            InitializeComponent();
        }

        private void Nuestra_historia_Load(object sender, EventArgs e)
        {
            //todo esto hace que se reproduzca el sonido, también está en "COMPRA" y los forms "PLACEHOLDER"
            try
            {
                SoundPlayer reproductor = new SoundPlayer(@"C:\Users\sanch\source\repos\feddy\feddy\Resources\19 2000 instrumental low quality.wav");
                reproductor.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("acabron: " + ex.Message);
            }
            //habrá que cambiar la dirección del archivo para que jale en otra computadoraa
            //tal vez se pueda guardar en el archivo "Resources" pero no tengo ni idea de como
        }
    }
}
