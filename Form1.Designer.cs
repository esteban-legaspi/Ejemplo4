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
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cmboxTipoDestino = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
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
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14F);
            textBox1.Location = new Point(255, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 39);
            textBox1.TabIndex = 1;
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
            // button1
            // 
            button1.Location = new Point(37, 203);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(192, 203);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 6;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(363, 203);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 7;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = true;
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
            // label7
            // 
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Font = new Font("Segoe UI", 14F);
            label7.Location = new Point(231, 291);
            label7.Name = "label7";
            label7.Size = new Size(149, 32);
            label7.TabIndex = 11;
            label7.Text = "S/C";
            label7.TextAlign = ContentAlignment.TopRight;
            // 
            // label8
            // 
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Font = new Font("Segoe UI", 14F);
            label8.Location = new Point(231, 344);
            label8.Name = "label8";
            label8.Size = new Size(149, 32);
            label8.TabIndex = 12;
            label8.Text = "S/C";
            label8.TextAlign = ContentAlignment.TopRight;
            // 
            // label9
            // 
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Font = new Font("Segoe UI", 14F);
            label9.Location = new Point(231, 395);
            label9.Name = "label9";
            label9.Size = new Size(149, 32);
            label9.TabIndex = 13;
            label9.Text = "S/C";
            label9.TextAlign = ContentAlignment.TopRight;
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
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(cmboxTipoDestino);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Paquete Express";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private ComboBox cmboxTipoDestino;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}
