namespace Activities
{
    partial class PjActivities
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
            pictureBox1 = new PictureBox();
            btnAñdir = new Button();
            btnGuardar = new Button();
            btnCancelar = new Button();
            btnEliminar = new Button();
            label1 = new Label();
            TxtActividad = new TextBox();
            lstActividad = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.descarga;
            pictureBox1.Location = new Point(115, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(314, 139);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnAñdir
            // 
            btnAñdir.Location = new Point(33, 219);
            btnAñdir.Name = "btnAñdir";
            btnAñdir.Size = new Size(122, 23);
            btnAñdir.TabIndex = 1;
            btnAñdir.Text = "Añadir Actividad";
            btnAñdir.UseVisualStyleBackColor = true;
            btnAñdir.Click += btnAñdir_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(203, 219);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(408, 219);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(311, 219);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(33, 264);
            label1.Name = "label1";
            label1.Size = new Size(83, 21);
            label1.TabIndex = 5;
            label1.Text = "Actividad";
            // 
            // TxtActividad
            // 
            TxtActividad.Location = new Point(122, 264);
            TxtActividad.Name = "TxtActividad";
            TxtActividad.Size = new Size(361, 23);
            TxtActividad.TabIndex = 6;
            // 
            // lstActividad
            // 
            lstActividad.FormattingEnabled = true;
            lstActividad.ItemHeight = 15;
            lstActividad.Location = new Point(33, 304);
            lstActividad.Name = "lstActividad";
            lstActividad.Size = new Size(450, 109);
            lstActividad.TabIndex = 7;
            lstActividad.SelectedIndexChanged += lstActividad_SelectedIndexChanged;
            // 
            // PjActivities
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 450);
            Controls.Add(lstActividad);
            Controls.Add(TxtActividad);
            Controls.Add(label1);
            Controls.Add(btnEliminar);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(btnAñdir);
            Controls.Add(pictureBox1);
            Name = "PjActivities";
            Text = "PjActivities";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnAñdir;
        private Button btnGuardar;
        private Button btnCancelar;
        private Button btnEliminar;
        private Label label1;
        private TextBox TxtActividad;
        private ListBox lstActividad;
    }
}