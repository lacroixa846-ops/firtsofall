namespace feddy
{
    partial class Carrito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carrito));
            lblTitulo = new Label();
            lablTotalTexto = new Label();
            lblTotal = new Label();
            btnRealizarCompra = new Button();
            flpProductos = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(41, 44);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(303, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Tu carrito de compras:";
            // 
            // lablTotalTexto
            // 
            lablTotalTexto.AutoSize = true;
            lablTotalTexto.BackColor = Color.Transparent;
            lablTotalTexto.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lablTotalTexto.Location = new Point(75, 205);
            lablTotalTexto.Name = "lablTotalTexto";
            lablTotalTexto.Size = new Size(89, 37);
            lablTotalTexto.TabIndex = 1;
            lablTotalTexto.Text = "Total:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(205, 205);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(88, 37);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "$0.00";
            // 
            // btnRealizarCompra
            // 
            btnRealizarCompra.BackColor = Color.DarkOrange;
            btnRealizarCompra.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRealizarCompra.ForeColor = Color.White;
            btnRealizarCompra.Location = new Point(103, 249);
            btnRealizarCompra.Margin = new Padding(3, 4, 3, 4);
            btnRealizarCompra.Name = "btnRealizarCompra";
            btnRealizarCompra.Size = new Size(147, 45);
            btnRealizarCompra.TabIndex = 3;
            btnRealizarCompra.Text = "Realizar compra";
            btnRealizarCompra.UseVisualStyleBackColor = false;
            btnRealizarCompra.Click += button1_Click;
            // 
            // flpProductos
            // 
            flpProductos.AutoScroll = true;
            flpProductos.FlowDirection = FlowDirection.TopDown;
            flpProductos.Location = new Point(56, 84);
            flpProductos.Name = "flpProductos";
            flpProductos.Size = new Size(250, 128);
            flpProductos.TabIndex = 4;
            flpProductos.WrapContents = false;
            // 
            // Carrito
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(360, 331);
            Controls.Add(flpProductos);
            Controls.Add(btnRealizarCompra);
            Controls.Add(lblTotal);
            Controls.Add(lablTotalTexto);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Carrito";
            Text = "Carrito";
            Load += Carrito_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lablTotalTexto;
        private Label lblTotal;
        private Button btnRealizarCompra;
        private FlowLayoutPanel flpProductos;
    }
}