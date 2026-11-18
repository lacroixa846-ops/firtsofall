namespace feddy
{
    partial class Compra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblMensaje = new Label();
            lblTotal = new Label();
            lblMetodoPago = new Label();
            lstProductos = new ListBox();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(49, 69);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(60, 20);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Pizzeria";
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(49, 146);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(131, 20);
            lblMensaje.TabIndex = 1;
            lblMensaje.Text = "Compra realizada ";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(49, 339);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(84, 20);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Total: $0.00";
            // 
            // lblMetodoPago
            // 
            lblMetodoPago.AutoSize = true;
            lblMetodoPago.Location = new Point(49, 451);
            lblMetodoPago.Name = "lblMetodoPago";
            lblMetodoPago.Size = new Size(122, 20);
            lblMetodoPago.TabIndex = 3;
            lblMetodoPago.Text = "Metodo de pago";
            // 
            // lstProductos
            // 
            lstProductos.FormattingEnabled = true;
            lstProductos.Location = new Point(49, 197);
            lstProductos.Name = "lstProductos";
            lstProductos.Size = new Size(200, 44);
            lstProductos.TabIndex = 5;
            // 
            // Compra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(511, 600);
            Controls.Add(lstProductos);
            Controls.Add(lblMetodoPago);
            Controls.Add(lblTotal);
            Controls.Add(lblMensaje);
            Controls.Add(lblTitulo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Compra";
            Text = "Compra";
            Load += Compra_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblMensaje;
        private Label lblTotal;
        private Label lblMetodoPago;
        private ListBox lstProductos;
    }
}