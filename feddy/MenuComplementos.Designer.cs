namespace feddy
{
    partial class MenuComplementos
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
            btnRefresco = new Button();
            btnPapas = new Button();
            btnAlitas = new Button();
            btnPanoAjo = new Button();
            btnCarrito = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(365, 8);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(110, 20);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Complementos";
            // 
            // btnRefresco
            // 
            btnRefresco.Location = new Point(59, 52);
            btnRefresco.Name = "btnRefresco";
            btnRefresco.Size = new Size(94, 29);
            btnRefresco.TabIndex = 1;
            btnRefresco.Text = "Refresco";
            btnRefresco.UseVisualStyleBackColor = true;
            btnRefresco.Click += btnRefresco_Click;
            // 
            // btnPapas
            // 
            btnPapas.Location = new Point(563, 52);
            btnPapas.Name = "btnPapas";
            btnPapas.Size = new Size(94, 29);
            btnPapas.TabIndex = 2;
            btnPapas.Text = "Papas";
            btnPapas.UseVisualStyleBackColor = true;
            btnPapas.Click += btnPapas_Click;
            // 
            // btnAlitas
            // 
            btnAlitas.Location = new Point(61, 170);
            btnAlitas.Name = "btnAlitas";
            btnAlitas.Size = new Size(94, 29);
            btnAlitas.TabIndex = 3;
            btnAlitas.Text = "Alitas";
            btnAlitas.UseVisualStyleBackColor = true;
            btnAlitas.Click += btnAlitas_Click;
            // 
            // btnPanoAjo
            // 
            btnPanoAjo.Location = new Point(567, 184);
            btnPanoAjo.Name = "btnPanoAjo";
            btnPanoAjo.Size = new Size(94, 29);
            btnPanoAjo.TabIndex = 4;
            btnPanoAjo.Text = "Pan de ajo";
            btnPanoAjo.UseVisualStyleBackColor = true;
            btnPanoAjo.Click += btnPanAjo_Click;
            // 
            // btnCarrito
            // 
            btnCarrito.Location = new Point(340, 343);
            btnCarrito.Name = "btnCarrito";
            btnCarrito.Size = new Size(94, 29);
            btnCarrito.TabIndex = 5;
            btnCarrito.Text = "Ver carrito";
            btnCarrito.UseVisualStyleBackColor = true;
            btnCarrito.Click += btnCarrito_Click;
            // 
            // MenuComplementos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCarrito);
            Controls.Add(btnPanoAjo);
            Controls.Add(btnAlitas);
            Controls.Add(btnPapas);
            Controls.Add(btnRefresco);
            Controls.Add(lblTitulo);
            Name = "MenuComplementos";
            Text = "MenuComplementos";
            Load += MenuComplementos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnRefresco;
        private Button btnPapas;
        private Button btnAlitas;
        private Button btnPanoAjo;
        private Button btnCarrito;
    }
}