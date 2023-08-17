namespace Tienda_Ejer1
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
            VentanaCantidad = new TextBox();
            Canti = new Label();
            Precio1 = new Label();
            VentanaPrecio = new TextBox();
            VentanaTotal = new TextBox();
            Tot = new Label();
            Calcular = new Button();
            SuspendLayout();
            // 
            // VentanaCantidad
            // 
            VentanaCantidad.BackColor = SystemColors.Menu;
            VentanaCantidad.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            VentanaCantidad.ForeColor = SystemColors.WindowFrame;
            VentanaCantidad.Location = new Point(118, 190);
            VentanaCantidad.Name = "VentanaCantidad";
            VentanaCantidad.Size = new Size(81, 25);
            VentanaCantidad.TabIndex = 0;
            VentanaCantidad.TextChanged += textBox1_TextChanged;
            // 
            // Canti
            // 
            Canti.AutoSize = true;
            Canti.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Canti.Location = new Point(12, 189);
            Canti.Name = "Canti";
            Canti.Size = new Size(100, 24);
            Canti.TabIndex = 2;
            Canti.Text = "Cantidad";
            Canti.Click += Canti_Click;
            // 
            // Precio1
            // 
            Precio1.AutoSize = true;
            Precio1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Precio1.Location = new Point(28, 253);
            Precio1.Name = "Precio1";
            Precio1.Size = new Size(74, 24);
            Precio1.TabIndex = 3;
            Precio1.Text = "Precio";
            Precio1.Click += label1_Click;
            // 
            // VentanaPrecio
            // 
            VentanaPrecio.BackColor = SystemColors.Menu;
            VentanaPrecio.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            VentanaPrecio.ForeColor = SystemColors.WindowFrame;
            VentanaPrecio.Location = new Point(118, 253);
            VentanaPrecio.Name = "VentanaPrecio";
            VentanaPrecio.Size = new Size(81, 26);
            VentanaPrecio.TabIndex = 4;
            VentanaPrecio.TextChanged += textBox2_TextChanged;
            // 
            // VentanaTotal
            // 
            VentanaTotal.BackColor = SystemColors.Menu;
            VentanaTotal.Enabled = false;
            VentanaTotal.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            VentanaTotal.ForeColor = SystemColors.MenuText;
            VentanaTotal.Location = new Point(127, 91);
            VentanaTotal.Name = "VentanaTotal";
            VentanaTotal.Size = new Size(189, 25);
            VentanaTotal.TabIndex = 5;
            VentanaTotal.TextChanged += textBox3_TextChanged;
            // 
            // Tot
            // 
            Tot.AutoSize = true;
            Tot.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Tot.Location = new Point(192, 48);
            Tot.Name = "Tot";
            Tot.Size = new Size(65, 24);
            Tot.TabIndex = 6;
            Tot.Text = "Total:";
            Tot.Click += Tot_Click;
            // 
            // Calcular
            // 
            Calcular.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Calcular.Location = new Point(262, 220);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(102, 31);
            Calcular.TabIndex = 7;
            Calcular.Text = "Calcular";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += Calcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(440, 450);
            Controls.Add(Calcular);
            Controls.Add(Tot);
            Controls.Add(VentanaTotal);
            Controls.Add(VentanaPrecio);
            Controls.Add(Precio1);
            Controls.Add(Canti);
            Controls.Add(VentanaCantidad);
            Name = "Form1";
            Text = "Ventas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox VentanaCantidad;
        private Label Canti;
        private Label Precio1;
        private TextBox VentanaPrecio;
        private TextBox VentanaTotal;
        private Label Tot;
        private Button Calcular;
    }
}