namespace Pormedio_Ejer2
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
            label2 = new Label();
            label3 = new Label();
            Ventana1 = new TextBox();
            Ventana2 = new TextBox();
            Ventana3 = new TextBox();
            Total = new TextBox();
            label4 = new Label();
            Calcular = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(26, 174);
            label1.Name = "label1";
            label1.Size = new Size(77, 24);
            label1.TabIndex = 0;
            label1.Text = "Nota 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(26, 230);
            label2.Name = "label2";
            label2.Size = new Size(77, 24);
            label2.TabIndex = 1;
            label2.Text = "Nota 2:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(26, 279);
            label3.Name = "label3";
            label3.Size = new Size(77, 24);
            label3.TabIndex = 2;
            label3.Text = "Nota 3:";
            label3.Click += label3_Click;
            // 
            // Ventana1
            // 
            Ventana1.Location = new Point(119, 175);
            Ventana1.Name = "Ventana1";
            Ventana1.Size = new Size(102, 23);
            Ventana1.TabIndex = 3;
            Ventana1.TextChanged += Ventana1_TextChanged;
            // 
            // Ventana2
            // 
            Ventana2.Location = new Point(119, 230);
            Ventana2.Name = "Ventana2";
            Ventana2.Size = new Size(102, 23);
            Ventana2.TabIndex = 4;
            Ventana2.TextChanged += Ventana2_TextChanged;
            // 
            // Ventana3
            // 
            Ventana3.Location = new Point(119, 279);
            Ventana3.Name = "Ventana3";
            Ventana3.Size = new Size(102, 23);
            Ventana3.TabIndex = 5;
            Ventana3.TextChanged += Ventana3_TextChanged;
            // 
            // Total
            // 
            Total.Enabled = false;
            Total.Location = new Point(130, 80);
            Total.Name = "Total";
            Total.Size = new Size(188, 23);
            Total.TabIndex = 6;
            Total.TextChanged += Total_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(173, 42);
            label4.Name = "label4";
            label4.Size = new Size(104, 24);
            label4.TabIndex = 7;
            label4.Text = "Promedio:";
            // 
            // Calcular
            // 
            Calcular.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Calcular.Location = new Point(296, 218);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(88, 36);
            Calcular.TabIndex = 8;
            Calcular.Text = "Calcular";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += Calcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(466, 450);
            Controls.Add(Calcular);
            Controls.Add(label4);
            Controls.Add(Total);
            Controls.Add(Ventana3);
            Controls.Add(Ventana2);
            Controls.Add(Ventana1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Promedio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Ventana1;
        private TextBox Ventana2;
        private TextBox Ventana3;
        private TextBox Total;
        private Label label4;
        private Button Calcular;
    }
}