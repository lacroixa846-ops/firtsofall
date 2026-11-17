using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace feddy
{
    //Aquí irá todo sobre la pizza personalizada, claro que sigue sin terminar el diseño pero hay me lo rifo en fa
    public partial class Tuneo_de_Pizza : Form
    {
        private CatalogoPizzas catalogo;
        private Pizza pizzaActual;

        public Tuneo_de_Pizza()
        {
            InitializeComponent();
            catalogo = SesionCatalogo.GetCatalogo();

            CargarIngredientes();

            cmbQueso.SelectedIndex = 0;
            cmbSalsa.SelectedIndex = 0;
        }
        private void CargarIngredientes()
        {
            clbIngredientes.Items.Clear();

            foreach (Ingrediente ingrediente in catalogo.GetIngredientes())
            {
                clbIngredientes.Items.Add(ingrediente.GetNombre());
            }
        }

        internal void IniciarPersonalizacion(TamanoPizza tamano)
        {
            pizzaActual = catalogo.CrearPizzaPersonalizada(
                "Pizza personalizada",
                tamano
            );

            ActualizarPrecio();
        }

        private void AgregarIngrediente(int idIngrediente)
        {
            if (pizzaActual == null)
            {
                return;
            }

            foreach (Ingrediente ingrediente in catalogo.GetIngredientes())
            {
                if (ingrediente.GetIdIngrediente() == idIngrediente)
                {
                    pizzaActual.AgregarIngrediente(ingrediente);
                    break;
                }
            }

            ActualizarPrecio();
        }

        private void SeleccionarTamano()
        {
            TamanoPizza tamano = null;

            if (cmbTamano.SelectedItem == null)
            {
                return;
            }

            string seleccion = cmbTamano.SelectedItem.ToString();

            if (seleccion == "Chico")
            {
                tamano = catalogo.GetChico();
            }
            else if (seleccion == "Mediano")
            {
                tamano = catalogo.GetMediano();
            }
            else if (seleccion == "Grande")
            {
                tamano = catalogo.GetGrande();
            }

            if (tamano != null)
            {
                IniciarPersonalizacion(tamano);
                ActualizarOrilla();
                ActualizarQueso();
                ActualizarSalsa();
                ActualizarIngredientes();
            }
        }

        private void Tuneo_de_Pizza_Load(object sender, EventArgs e)
        {

        }

        private void cmbTamano_SelectedIndexChanged(object sender, EventArgs e)
        {
            SeleccionarTamano();
        }

        private void ActualizarOrilla()
        {
            if (pizzaActual != null)
            {
                pizzaActual.SetOrillaQueso(chkOrillaQueso.Checked);
                ActualizarPrecio();
            }
        }

        private void chkOrillaQueso_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarOrilla();
        }

        private void ActualizarQueso()
        {
            if (pizzaActual == null || cmbQueso.SelectedIndex == -1)
            {
                return;
            }

            if (cmbQueso.SelectedIndex == 0)
            {
                pizzaActual.SetPorcionesQueso(1);
            }
            else if (cmbQueso.SelectedIndex == 1)
            {
                pizzaActual.SetPorcionesQueso(2);
            }

            ActualizarPrecio();
        }

        private void cmbQueso_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarQueso();
        }

        private void ActualizarSalsa()
        {
            if (pizzaActual == null || cmbSalsa.SelectedIndex == -1)
            {
                return;
            }

            if (cmbSalsa.SelectedIndex == 0)
            {
                pizzaActual.SetSalsa("Normal");
            }
            else if (cmbSalsa.SelectedIndex == 1)
            {
                pizzaActual.SetSalsa("Extra");
            }
            else if (cmbSalsa.SelectedIndex == 2)
            {
                pizzaActual.SetSalsa("Doble");
            }

            ActualizarPrecio();
        }

        private void cmbSalsa_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarSalsa();
        }

        private void ActualizarIngredientes()
        {
            if (pizzaActual == null)
            {
                return;
            }

            List<Ingrediente> ingredientes = catalogo.GetIngredientes();

            for (int i = 0; i < ingredientes.Count; i++)
            {
                if (clbIngredientes.GetItemChecked(i))
                {
                    if (!pizzaActual.GetIngredientes().Contains(ingredientes[i]))
                    {
                        pizzaActual.AgregarIngrediente(ingredientes[i]);
                    }
                }
                else
                {
                    pizzaActual.QuitarIngrediente(ingredientes[i]);
                }
            }

            ActualizarPrecio();
        }

        private void clbIngredientes_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            BeginInvoke(new Action(ActualizarIngredientes));
        }

        private void ActualizarPrecio()
        {
            if (pizzaActual != null)
            {
                lblPrecio.Text = "$" + pizzaActual.CalcularPrecio().ToString("0.00");
            }
        }

        private void btnAgregarCarrito_Click(object sender, EventArgs e)
        {
            if (pizzaActual == null)
            {
                MessageBox.Show("Selecciona un tamaño para tu pizza.");
                return;
            }

            SesionPedido.GetCarrito().AgregarProducto(pizzaActual);

            MessageBox.Show("¡Pizza agregada al carrito!");

            Carrito ventana = new Carrito();
            ventana.Show();

            this.Close();
        }
    }
}
