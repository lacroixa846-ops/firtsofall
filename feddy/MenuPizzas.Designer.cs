namespace feddy
{
    partial class MenuPizzas
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
            btnPepperoni = new Button();
            btnQueso = new Button();
            btnTresCarnes = new Button();
            btnHawaiana = new Button();
            btnOrillaRellena = new Button();
            lblTitulo = new Label();
            btnCarrito = new Label();
            SuspendLayout();
            // 
            // btnPepperoni
            // 
            btnPepperoni.Location = new Point(62, 74);
            btnPepperoni.Name = "btnPepperoni";
            btnPepperoni.Size = new Size(147, 36);
            btnPepperoni.TabIndex = 0;
            btnPepperoni.Text = "Pepperoni - $99";
            btnPepperoni.UseVisualStyleBackColor = true;
            btnPepperoni.Click += btnPepperoni_Click;
            // 
            // btnQueso
            // 
            btnQueso.Location = new Point(547, 74);
            btnQueso.Name = "btnQueso";
            btnQueso.Size = new Size(144, 36);
            btnQueso.TabIndex = 1;
            btnQueso.Text = "Queso - $89";
            btnQueso.UseVisualStyleBackColor = true;
            // 
            // btnTresCarnes
            // 
            btnTresCarnes.Location = new Point(62, 152);
            btnTresCarnes.Name = "btnTresCarnes";
            btnTresCarnes.Size = new Size(158, 34);
            btnTresCarnes.TabIndex = 2;
            btnTresCarnes.Text = "3 Carnes - $189";
            btnTresCarnes.UseVisualStyleBackColor = true;
            // 
            // btnHawaiana
            // 
            btnHawaiana.Location = new Point(547, 152);
            btnHawaiana.Name = "btnHawaiana";
            btnHawaiana.Size = new Size(144, 34);
            btnHawaiana.TabIndex = 3;
            btnHawaiana.Text = "Hawaiana - $189";
            btnHawaiana.UseVisualStyleBackColor = true;
            // 
            // btnOrillaRellena
            // 
            btnOrillaRellena.Location = new Point(62, 234);
            btnOrillaRellena.Name = "btnOrillaRellena";
            btnOrillaRellena.Size = new Size(158, 31);
            btnOrillaRellena.TabIndex = 4;
            btnOrillaRellena.Text = "Orilla Rellena - $189";
            btnOrillaRellena.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(346, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(112, 20);
            lblTitulo.TabIndex = 5;
            lblTitulo.Text = "Menu de pizzas";
            // 
            // btnCarrito
            // 
            btnCarrito.AutoSize = true;
            btnCarrito.Location = new Point(559, 318);
            btnCarrito.Name = "btnCarrito";
            btnCarrito.Size = new Size(77, 20);
            btnCarrito.TabIndex = 6;
            btnCarrito.Text = "Ver carrito";
            // 
            // MenuPizzas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 450);
            Controls.Add(btnCarrito);
            Controls.Add(lblTitulo);
            Controls.Add(btnOrillaRellena);
            Controls.Add(btnHawaiana);
            Controls.Add(btnTresCarnes);
            Controls.Add(btnQueso);
            Controls.Add(btnPepperoni);
            Name = "MenuPizzas";
            Text = "MenuPizzas";
            Load += MenuPizzas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPepperoni;
        private Button btnQueso;
        private Button btnTresCarnes;
        private Button btnHawaiana;
        private Button btnOrillaRellena;
        private Label lblTitulo;
        private Label btnCarrito;
    }
}