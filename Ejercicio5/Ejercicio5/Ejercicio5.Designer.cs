namespace Ejercicio5
{
    partial class Ejercicio5
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            VentanaP = new TextBox();
            VentanaC = new TextBox();
            VentanaD = new TextBox();
            VentanaT = new TextBox();
            Calcular = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(61, 100);
            label1.Name = "label1";
            label1.Size = new Size(68, 22);
            label1.TabIndex = 0;
            label1.Text = "Precio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(312, 100);
            label2.Name = "label2";
            label2.Size = new Size(100, 22);
            label2.TabIndex = 1;
            label2.Text = "Descuento:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(191, 100);
            label3.Name = "label3";
            label3.Size = new Size(90, 22);
            label3.TabIndex = 2;
            label3.Text = "Cantidad:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(172, 268);
            label4.Name = "label4";
            label4.Size = new Size(125, 22);
            label4.TabIndex = 3;
            label4.Text = "Total a pagar:";
            label4.Click += label4_Click;
            // 
            // VentanaP
            // 
            VentanaP.Location = new Point(44, 135);
            VentanaP.Name = "VentanaP";
            VentanaP.Size = new Size(100, 23);
            VentanaP.TabIndex = 4;
            VentanaP.TextChanged += VentanaP_TextChanged;
            // 
            // VentanaC
            // 
            VentanaC.Location = new Point(181, 135);
            VentanaC.Name = "VentanaC";
            VentanaC.Size = new Size(100, 23);
            VentanaC.TabIndex = 5;
            VentanaC.TextChanged += VentanaC_TextChanged;
            // 
            // VentanaD
            // 
            VentanaD.Enabled = false;
            VentanaD.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            VentanaD.Location = new Point(312, 135);
            VentanaD.Name = "VentanaD";
            VentanaD.Size = new Size(100, 26);
            VentanaD.TabIndex = 6;
            VentanaD.Text = "11 %";
            VentanaD.TextAlign = HorizontalAlignment.Center;
            // 
            // VentanaT
            // 
            VentanaT.Enabled = false;
            VentanaT.Location = new Point(172, 307);
            VentanaT.Name = "VentanaT";
            VentanaT.Size = new Size(126, 23);
            VentanaT.TabIndex = 7;
            // 
            // Calcular
            // 
            Calcular.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Calcular.Location = new Point(191, 200);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(90, 28);
            Calcular.TabIndex = 8;
            Calcular.Text = "Calcular";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += Calcular_Click;
            // 
            // Ejercicio5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(481, 450);
            Controls.Add(Calcular);
            Controls.Add(VentanaT);
            Controls.Add(VentanaD);
            Controls.Add(VentanaC);
            Controls.Add(VentanaP);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Ejercicio5";
            Text = "Ejercicio5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox VentanaP;
        private TextBox VentanaC;
        private TextBox VentanaD;
        private TextBox VentanaT;
        private Button Calcular;
    }
}