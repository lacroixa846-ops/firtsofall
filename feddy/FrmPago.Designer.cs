namespace feddy
{
    partial class FrmPago
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
            lblTotalPago = new Label();
            rdbEfectivo = new RadioButton();
            rdbTransferencia = new RadioButton();
            btnConfirmarPago = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(52, 28);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(122, 20);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Metodo de pago";
            // 
            // lblTotalPago
            // 
            lblTotalPago.AutoSize = true;
            lblTotalPago.Location = new Point(54, 72);
            lblTotalPago.Name = "lblTotalPago";
            lblTotalPago.Size = new Size(88, 20);
            lblTotalPago.TabIndex = 1;
            lblTotalPago.Text = "Total: %0.00";
            // 
            // rdbEfectivo
            // 
            rdbEfectivo.AutoSize = true;
            rdbEfectivo.Location = new Point(57, 122);
            rdbEfectivo.Name = "rdbEfectivo";
            rdbEfectivo.Size = new Size(83, 24);
            rdbEfectivo.TabIndex = 2;
            rdbEfectivo.TabStop = true;
            rdbEfectivo.Text = "Efectivo";
            rdbEfectivo.UseVisualStyleBackColor = true;
            // 
            // rdbTransferencia
            // 
            rdbTransferencia.AutoSize = true;
            rdbTransferencia.Location = new Point(56, 172);
            rdbTransferencia.Name = "rdbTransferencia";
            rdbTransferencia.Size = new Size(117, 24);
            rdbTransferencia.TabIndex = 3;
            rdbTransferencia.TabStop = true;
            rdbTransferencia.Text = "Transferencia";
            rdbTransferencia.UseVisualStyleBackColor = true;
            // 
            // btnConfirmarPago
            // 
            btnConfirmarPago.Location = new Point(65, 231);
            btnConfirmarPago.Name = "btnConfirmarPago";
            btnConfirmarPago.Size = new Size(160, 29);
            btnConfirmarPago.TabIndex = 4;
            btnConfirmarPago.Text = "Confirmar compra";
            btnConfirmarPago.UseVisualStyleBackColor = true;
            btnConfirmarPago.Click += btnConfirmarPago_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(68, 293);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(157, 29);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Regresar al carrito";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmPago
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmarPago);
            Controls.Add(rdbTransferencia);
            Controls.Add(rdbEfectivo);
            Controls.Add(lblTotalPago);
            Controls.Add(lblTitulo);
            Name = "FrmPago";
            Text = "FrmPago";
            Load += FrmPago_Load;
            Click += btnConfirmarPago_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblTotalPago;
        private RadioButton rdbEfectivo;
        private RadioButton rdbTransferencia;
        private Button btnConfirmarPago;
        private Button btnCancelar;
    }
}