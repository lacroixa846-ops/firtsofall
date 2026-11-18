namespace feddy
{
    partial class MenuPaquetes
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
            btnPaquete1 = new Button();
            btnPaquete2 = new Button();
            btnPaquete3 = new Button();
            btnCarrito = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Arial Narrow", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(313, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(143, 40);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Paquetes";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnPaquete1
            // 
            btnPaquete1.Location = new Point(51, 81);
            btnPaquete1.Name = "btnPaquete1";
            btnPaquete1.Size = new Size(216, 29);
            btnPaquete1.TabIndex = 1;
            btnPaquete1.Text = "Paquete individual - $119";
            btnPaquete1.UseVisualStyleBackColor = true;
            btnPaquete1.Click += btnPaquete1_Click;
            // 
            // btnPaquete2
            // 
            btnPaquete2.Location = new Point(51, 195);
            btnPaquete2.Name = "btnPaquete2";
            btnPaquete2.Size = new Size(215, 29);
            btnPaquete2.TabIndex = 2;
            btnPaquete2.Text = "Paquete especial - $219";
            btnPaquete2.UseVisualStyleBackColor = true;
            btnPaquete2.Click += btnPaquete2_Click;
            // 
            // btnPaquete3
            // 
            btnPaquete3.Location = new Point(50, 327);
            btnPaquete3.Name = "btnPaquete3";
            btnPaquete3.Size = new Size(216, 29);
            btnPaquete3.TabIndex = 3;
            btnPaquete3.Text = "Paquete familiar - $349";
            btnPaquete3.UseVisualStyleBackColor = true;
            btnPaquete3.Click += btnPaquete3_Click;
            // 
            // btnCarrito
            // 
            btnCarrito.Location = new Point(565, 195);
            btnCarrito.Name = "btnCarrito";
            btnCarrito.Size = new Size(94, 29);
            btnCarrito.TabIndex = 4;
            btnCarrito.Text = "Ver carrito";
            btnCarrito.UseVisualStyleBackColor = true;
            btnCarrito.Click += btnCarrito_Click;
            // 
            // MenuPaquetes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCarrito);
            Controls.Add(btnPaquete3);
            Controls.Add(btnPaquete2);
            Controls.Add(btnPaquete1);
            Controls.Add(lblTitulo);
            Name = "MenuPaquetes";
            Text = "MenuPaquetes";
            Load += MenuPaquetes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnPaquete1;
        private Button btnPaquete2;
        private Button btnPaquete3;
        private Button btnCarrito;
    }
}