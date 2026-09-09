namespace Ejemplo4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtPesoPaquete = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cmboxTipoDestino = new ComboBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lblCostoFlete = new Label();
            lblIVA = new Label();
            lblTotal = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(26, 25);
            label1.Name = "label1";
            label1.Size = new Size(208, 32);
            label1.TabIndex = 0;
            label1.Text = "Peso del Paquete: ";
            // 
            // txtPesoPaquete
            // 
            txtPesoPaquete.Font = new Font("Segoe UI", 14F);
            txtPesoPaquete.Location = new Point(255, 25);
            txtPesoPaquete.Name = "txtPesoPaquete";
            txtPesoPaquete.Size = new Size(125, 39);
            txtPesoPaquete.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(415, 28);
            label2.Name = "label2";
            label2.Size = new Size(42, 32);
            label2.TabIndex = 2;
            label2.Text = "Kg";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(37, 121);
            label3.Name = "label3";
            label3.Size = new Size(162, 32);
            label3.TabIndex = 3;
            label3.Text = "Tipo Destino: ";
            // 
            // cmboxTipoDestino
            // 
            cmboxTipoDestino.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmboxTipoDestino.FormattingEnabled = true;
            cmboxTipoDestino.Items.AddRange(new object[] { "Nacional", "Internacional" });
            cmboxTipoDestino.Location = new Point(255, 114);
            cmboxTipoDestino.Name = "cmboxTipoDestino";
            cmboxTipoDestino.Size = new Size(125, 39);
            cmboxTipoDestino.TabIndex = 4;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(37, 203);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(192, 203);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(363, 203);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(26, 291);
            label4.Name = "label4";
            label4.Size = new Size(180, 32);
            label4.TabIndex = 8;
            label4.Text = "Costo de Flete: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(26, 344);
            label5.Name = "label5";
            label5.Size = new Size(61, 32);
            label5.TabIndex = 9;
            label5.Text = "IVA: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.Location = new Point(26, 395);
            label6.Name = "label6";
            label6.Size = new Size(70, 32);
            label6.TabIndex = 10;
            label6.Text = "Total:";
            // 
            // lblCostoFlete
            // 
            lblCostoFlete.BorderStyle = BorderStyle.FixedSingle;
            lblCostoFlete.Font = new Font("Segoe UI", 14F);
            lblCostoFlete.Location = new Point(231, 291);
            lblCostoFlete.Name = "lblCostoFlete";
            lblCostoFlete.Size = new Size(149, 32);
            lblCostoFlete.TabIndex = 11;
            lblCostoFlete.Text = "S/C";
            lblCostoFlete.TextAlign = ContentAlignment.TopRight;
            // 
            // lblIVA
            // 
            lblIVA.BorderStyle = BorderStyle.FixedSingle;
            lblIVA.Font = new Font("Segoe UI", 14F);
            lblIVA.Location = new Point(231, 344);
            lblIVA.Name = "lblIVA";
            lblIVA.Size = new Size(149, 32);
            lblIVA.TabIndex = 12;
            lblIVA.Text = "S/C";
            lblIVA.TextAlign = ContentAlignment.TopRight;
            // 
            // lblTotal
            // 
            lblTotal.BorderStyle = BorderStyle.FixedSingle;
            lblTotal.Font = new Font("Segoe UI", 14F);
            lblTotal.Location = new Point(231, 395);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(149, 32);
            lblTotal.TabIndex = 13;
            lblTotal.Text = "S/C";
            lblTotal.TextAlign = ContentAlignment.TopRight;
            // 
            // label10
            // 
            label10.BackColor = SystemColors.HotTrack;
            label10.Font = new Font("Segoe UI", 14F);
            label10.Location = new Point(12, 462);
            label10.Name = "label10";
            label10.Size = new Size(776, 32);
            label10.TabIndex = 14;
            label10.Text = "Proporcione los datos de su envío";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 503);
            Controls.Add(label10);
            Controls.Add(lblTotal);
            Controls.Add(lblIVA);
            Controls.Add(lblCostoFlete);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(cmboxTipoDestino);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPesoPaquete);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Paquete Express";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPesoPaquete;
        private Label label2;
        private Label label3;
        private ComboBox cmboxTipoDestino;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnSalir;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lblCostoFlete;
        private Label lblIVA;
        private Label lblTotal;
        private Label label10;
    }
}
