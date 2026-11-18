using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace feddy
{
    public partial class FrmPago : Form
    {
        private Carriton gestorCarrito;
        private decimal totalPagar;

        public FrmPago()
        {
            InitializeComponent();
            gestorCarrito = SesionPedido.GetCarrito();
            totalPagar = gestorCarrito.CalcularSubtotal();
        }
        private void FrmPago_Load(object sender, EventArgs e)
        {
            lblTotalPago.Text = "Total: $" + totalPagar.ToString("0.00");
        }

        private void btnConfirmarPago_Click(object sender, EventArgs e)
        {
            if (!rdbEfectivo.Checked && !rdbTransferencia.Checked)
            {
                MessageBox.Show("Selecciona un método de pago.");
                return;
            }

            string metodo = rdbEfectivo.Checked
                ? "Efectivo"
                : "Transferencia";

            Compra ventana = new Compra(metodo);
            ventana.ShowDialog();

            this.Hide();
        }
        private void btnConfirmarPago_Click_1(object sender, EventArgs e)
        {
            btnConfirmarPago_Click(sender, e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Carrito ventana = new Carrito();
            ventana.Show();
            this.Close();
        }
    }
}
