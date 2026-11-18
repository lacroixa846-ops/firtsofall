namespace feddy
{
    partial class pedido
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
            label1 = new Label();
            btnPizzas = new Button();
            btnComplementos = new Button();
            btnPaquetes = new Button();
            btnCrear = new Button();
            btnCarrito = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(350, 297);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // btnPizzas
            // 
            btnPizzas.Location = new Point(141, 40);
            btnPizzas.Name = "btnPizzas";
            btnPizzas.Size = new Size(94, 29);
            btnPizzas.TabIndex = 1;
            btnPizzas.Text = "Pizzas";
            btnPizzas.UseVisualStyleBackColor = true;
            btnPizzas.Click += btnPizzas_Click;
            // 
            // btnComplementos
            // 
            btnComplementos.Location = new Point(463, 40);
            btnComplementos.Name = "btnComplementos";
            btnComplementos.Size = new Size(94, 29);
            btnComplementos.TabIndex = 2;
            btnComplementos.Text = "Complementos";
            btnComplementos.UseVisualStyleBackColor = true;
            btnComplementos.Click += btnComplementos_Click;
            // 
            // btnPaquetes
            // 
            btnPaquetes.Location = new Point(141, 162);
            btnPaquetes.Name = "btnPaquetes";
            btnPaquetes.Size = new Size(94, 29);
            btnPaquetes.TabIndex = 3;
            btnPaquetes.Text = "Paquetes";
            btnPaquetes.UseVisualStyleBackColor = true;
            btnPaquetes.Click += btnPaquetes_Click;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(463, 162);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(94, 29);
            btnCrear.TabIndex = 4;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnCarrito
            // 
            btnCarrito.Location = new Point(141, 288);
            btnCarrito.Name = "btnCarrito";
            btnCarrito.Size = new Size(94, 29);
            btnCarrito.TabIndex = 5;
            btnCarrito.Text = "Ver carrito";
            btnCarrito.UseVisualStyleBackColor = true;
            btnCarrito.Click += btnCarrito_Click;
            // 
            // pedido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(btnCarrito);
            Controls.Add(btnCrear);
            Controls.Add(btnPaquetes);
            Controls.Add(btnComplementos);
            Controls.Add(btnPizzas);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "pedido";
            Text = "pedido";
            Load += pedido_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnPizzas;
        private Button btnComplementos;
        private Button btnPaquetes;
        private Button btnCrear;
        private Button btnCarrito;
    }
}