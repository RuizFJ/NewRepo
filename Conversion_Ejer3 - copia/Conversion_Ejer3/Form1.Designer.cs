namespace Conversion_Ejer3
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
            Etiqueta1 = new Label();
            ListaC = new ComboBox();
            Metros = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            VentanaCantidad = new TextBox();
            VentanaResult = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // Etiqueta1
            // 
            Etiqueta1.AutoSize = true;
            Etiqueta1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Etiqueta1.Location = new Point(182, 62);
            Etiqueta1.Name = "Etiqueta1";
            Etiqueta1.Size = new Size(188, 24);
            Etiqueta1.TabIndex = 0;
            Etiqueta1.Text = "Unidades de medida";
            // 
            // ListaC
            // 
            ListaC.FormattingEnabled = true;
            ListaC.Items.AddRange(new object[] { "Centimetros", "Pulgadas", "Pies", "Yardas" });
            ListaC.Location = new Point(373, 160);
            ListaC.Name = "ListaC";
            ListaC.Size = new Size(121, 23);
            ListaC.TabIndex = 3;
            // 
            // Metros
            // 
            Metros.FormattingEnabled = true;
            Metros.Items.AddRange(new object[] { "Metros" });
            Metros.Location = new Point(68, 160);
            Metros.Name = "Metros";
            Metros.Size = new Size(121, 23);
            Metros.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(68, 131);
            label1.Name = "label1";
            label1.Size = new Size(38, 22);
            label1.TabIndex = 5;
            label1.Text = "De:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(373, 131);
            label2.Name = "label2";
            label2.Size = new Size(28, 22);
            label2.TabIndex = 6;
            label2.Text = "A:";
            // 
            // VentanaCantidad
            // 
            VentanaCantidad.Location = new Point(68, 314);
            VentanaCantidad.Name = "VentanaCantidad";
            VentanaCantidad.Size = new Size(121, 23);
            VentanaCantidad.TabIndex = 7;
            VentanaCantidad.TextChanged += VentanaCantidad_TextChanged;
            // 
            // VentanaResult
            // 
            VentanaResult.Enabled = false;
            VentanaResult.Location = new Point(373, 314);
            VentanaResult.Name = "VentanaResult";
            VentanaResult.Size = new Size(121, 23);
            VentanaResult.TabIndex = 8;
            VentanaResult.TextChanged += VentanaResult_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(68, 277);
            label3.Name = "label3";
            label3.Size = new Size(176, 22);
            label3.TabIndex = 9;
            label3.Text = "Cantidad a calcular:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(373, 277);
            label4.Name = "label4";
            label4.Size = new Size(97, 22);
            label4.TabIndex = 10;
            label4.Text = "Resultado:";
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalcular.Location = new Point(247, 226);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(83, 28);
            btnCalcular.TabIndex = 11;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalcular);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(VentanaResult);
            Controls.Add(VentanaCantidad);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Metros);
            Controls.Add(ListaC);
            Controls.Add(Etiqueta1);
            Name = "Form1";
            Text = "Resultado:";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Etiqueta1;
        private ComboBox ListaC;
        private ComboBox Metros;
        private Label label1;
        private Label label2;
        private TextBox VentanaCantidad;
        private TextBox VentanaResult;
        private Label label3;
        private Label label4;
        private Button btnCalcular;
    }
}