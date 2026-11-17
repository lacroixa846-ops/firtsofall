namespace feddy
{
    partial class Tuneo_de_Pizza
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
            cmbTamano = new ComboBox();
            chkOrillaQueso = new CheckBox();
            cmbQueso = new ComboBox();
            cmbSalsa = new ComboBox();
            clbIngredientes = new CheckedListBox();
            lblPrecio = new Label();
            btnAgregarCarrito = new Button();
            SuspendLayout();
            // 
            // cmbTamano
            // 
            cmbTamano.FormattingEnabled = true;
            cmbTamano.Items.AddRange(new object[] { "Chico", "", "Mediano", "", "Grande" });
            cmbTamano.Location = new Point(35, 80);
            cmbTamano.Name = "cmbTamano";
            cmbTamano.Size = new Size(151, 28);
            cmbTamano.TabIndex = 0;
            cmbTamano.SelectedIndexChanged += cmbTamano_SelectedIndexChanged;
            // 
            // chkOrillaQueso
            // 
            chkOrillaQueso.AutoSize = true;
            chkOrillaQueso.Location = new Point(514, 82);
            chkOrillaQueso.Name = "chkOrillaQueso";
            chkOrillaQueso.Size = new Size(229, 24);
            chkOrillaQueso.TabIndex = 1;
            chkOrillaQueso.Text = "Orilla rellena de queso (+$30)";
            chkOrillaQueso.UseVisualStyleBackColor = true;
            chkOrillaQueso.CheckedChanged += chkOrillaQueso_CheckedChanged;
            // 
            // cmbQueso
            // 
            cmbQueso.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbQueso.FormattingEnabled = true;
            cmbQueso.Items.AddRange(new object[] { "Normal (incluida)", "", "", "Doble (+$15)" });
            cmbQueso.Location = new Point(262, 80);
            cmbQueso.Name = "cmbQueso";
            cmbQueso.Size = new Size(146, 28);
            cmbQueso.TabIndex = 2;
            cmbQueso.SelectedIndexChanged += cmbQueso_SelectedIndexChanged;
            // 
            // cmbSalsa
            // 
            cmbSalsa.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSalsa.FormattingEnabled = true;
            cmbSalsa.Items.AddRange(new object[] { "Normal (incluida)", "", "Extra (+$5)", "", "Doble (+$10)" });
            cmbSalsa.Location = new Point(35, 191);
            cmbSalsa.Name = "cmbSalsa";
            cmbSalsa.Size = new Size(168, 28);
            cmbSalsa.TabIndex = 3;
            cmbSalsa.SelectedIndexChanged += cmbSalsa_SelectedIndexChanged;
            // 
            // clbIngredientes
            // 
            clbIngredientes.CheckOnClick = true;
            clbIngredientes.FormattingEnabled = true;
            clbIngredientes.Location = new Point(509, 178);
            clbIngredientes.Name = "clbIngredientes";
            clbIngredientes.Size = new Size(215, 114);
            clbIngredientes.TabIndex = 4;
            clbIngredientes.ItemCheck += clbIngredientes_ItemCheck;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(505, 380);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(48, 20);
            lblPrecio.TabIndex = 5;
            lblPrecio.Text = "%0.00";
            // 
            // btnAgregarCarrito
            // 
            btnAgregarCarrito.BackColor = SystemColors.ActiveCaptionText;
            btnAgregarCarrito.ForeColor = SystemColors.ControlLight;
            btnAgregarCarrito.Location = new Point(50, 342);
            btnAgregarCarrito.Name = "btnAgregarCarrito";
            btnAgregarCarrito.Size = new Size(153, 58);
            btnAgregarCarrito.TabIndex = 6;
            btnAgregarCarrito.Text = "Agregar al carrito";
            btnAgregarCarrito.UseVisualStyleBackColor = false;
            btnAgregarCarrito.Click += btnAgregarCarrito_Click;
            // 
            // Tuneo_de_Pizza
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnAgregarCarrito);
            Controls.Add(lblPrecio);
            Controls.Add(clbIngredientes);
            Controls.Add(cmbSalsa);
            Controls.Add(cmbQueso);
            Controls.Add(chkOrillaQueso);
            Controls.Add(cmbTamano);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Tuneo_de_Pizza";
            Text = "Tuneo_de_Pizza";
            Load += Tuneo_de_Pizza_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbTamano;
        private CheckBox chkOrillaQueso;
        private ComboBox cmbQueso;
        private ComboBox cmbSalsa;
        private CheckedListBox clbIngredientes;
        private Label lblPrecio;
        private Button btnAgregarCarrito;
    }
}