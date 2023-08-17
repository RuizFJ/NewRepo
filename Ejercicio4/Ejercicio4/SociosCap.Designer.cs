namespace Ejercicio4
{
    partial class SociosCap
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
            Ventana1 = new TextBox();
            Ventana2 = new TextBox();
            Ventana3 = new TextBox();
            Calcular = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            Porce1 = new TextBox();
            Porce2 = new TextBox();
            Porce3 = new TextBox();
            label8 = new Label();
            Capital = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(175, 51);
            label1.Name = "label1";
            label1.Size = new Size(128, 24);
            label1.TabIndex = 0;
            label1.Text = "Aportaciones";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(81, 91);
            label2.Name = "label2";
            label2.Size = new Size(75, 22);
            label2.TabIndex = 1;
            label2.Text = "Socio 1:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(214, 91);
            label3.Name = "label3";
            label3.Size = new Size(75, 22);
            label3.TabIndex = 2;
            label3.Text = "Socio 2:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(340, 91);
            label4.Name = "label4";
            label4.Size = new Size(75, 22);
            label4.TabIndex = 3;
            label4.Text = "Socio 3:";
            // 
            // Ventana1
            // 
            Ventana1.Location = new Point(65, 116);
            Ventana1.Name = "Ventana1";
            Ventana1.Size = new Size(100, 23);
            Ventana1.TabIndex = 4;
            Ventana1.TextChanged += Ventana1_TextChanged;
            // 
            // Ventana2
            // 
            Ventana2.Location = new Point(199, 116);
            Ventana2.Name = "Ventana2";
            Ventana2.Size = new Size(100, 23);
            Ventana2.TabIndex = 5;
            Ventana2.TextChanged += Ventana2_TextChanged;
            // 
            // Ventana3
            // 
            Ventana3.Location = new Point(331, 116);
            Ventana3.Name = "Ventana3";
            Ventana3.Size = new Size(100, 23);
            Ventana3.TabIndex = 6;
            Ventana3.TextChanged += Ventana3_TextChanged;
            // 
            // Calcular
            // 
            Calcular.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Calcular.Location = new Point(206, 162);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(83, 30);
            Calcular.TabIndex = 7;
            Calcular.Text = "Calcular";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += Calcular_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(65, 209);
            label5.Name = "label5";
            label5.Size = new Size(97, 19);
            label5.TabIndex = 8;
            label5.Text = "Porcentaje 1:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(199, 209);
            label6.Name = "label6";
            label6.Size = new Size(97, 19);
            label6.TabIndex = 9;
            label6.Text = "Porcentaje 2:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(331, 209);
            label7.Name = "label7";
            label7.Size = new Size(97, 19);
            label7.TabIndex = 10;
            label7.Text = "Porcentaje 3:";
            // 
            // Porce1
            // 
            Porce1.Enabled = false;
            Porce1.Location = new Point(65, 234);
            Porce1.Name = "Porce1";
            Porce1.Size = new Size(100, 23);
            Porce1.TabIndex = 11;
            // 
            // Porce2
            // 
            Porce2.Enabled = false;
            Porce2.Location = new Point(199, 234);
            Porce2.Name = "Porce2";
            Porce2.Size = new Size(100, 23);
            Porce2.TabIndex = 12;
            // 
            // Porce3
            // 
            Porce3.Enabled = false;
            Porce3.Location = new Point(331, 234);
            Porce3.Name = "Porce3";
            Porce3.Size = new Size(100, 23);
            Porce3.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(190, 283);
            label8.Name = "label8";
            label8.Size = new Size(122, 22);
            label8.TabIndex = 14;
            label8.Text = "Capital Total:";
            // 
            // Capital
            // 
            Capital.Enabled = false;
            Capital.Location = new Point(175, 320);
            Capital.Name = "Capital";
            Capital.Size = new Size(146, 23);
            Capital.TabIndex = 15;
            Capital.TextChanged += Capital_TextChanged;
            // 
            // SociosCap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(511, 450);
            Controls.Add(Capital);
            Controls.Add(label8);
            Controls.Add(Porce3);
            Controls.Add(Porce2);
            Controls.Add(Porce1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(Calcular);
            Controls.Add(Ventana3);
            Controls.Add(Ventana2);
            Controls.Add(Ventana1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SociosCap";
            Text = "SociosCap";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox Ventana1;
        private TextBox Ventana2;
        private TextBox Ventana3;
        private Button Calcular;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox Porce1;
        private TextBox Porce2;
        private TextBox Porce3;
        private Label label8;
        private TextBox Capital;
    }
}