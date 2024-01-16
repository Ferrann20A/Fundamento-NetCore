namespace Fundamentos
{
    partial class Form23Mascotas
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
            txtNombre = new TextBox();
            txtRaza = new TextBox();
            label2 = new Label();
            btnNuevaMascota = new Button();
            btnLeerMascotas = new Button();
            button2 = new Button();
            label3 = new Label();
            lstMascotas = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 41);
            label1.Name = "label1";
            label1.Size = new Size(98, 31);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(53, 84);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(210, 38);
            txtNombre.TabIndex = 1;
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(53, 188);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(210, 38);
            txtRaza.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 145);
            label2.Name = "label2";
            label2.Size = new Size(62, 31);
            label2.TabIndex = 2;
            label2.Text = "Raza";
            // 
            // btnNuevaMascota
            // 
            btnNuevaMascota.Location = new Point(53, 249);
            btnNuevaMascota.Name = "btnNuevaMascota";
            btnNuevaMascota.Size = new Size(210, 52);
            btnNuevaMascota.TabIndex = 4;
            btnNuevaMascota.Text = "Nueva Mascota";
            btnNuevaMascota.UseVisualStyleBackColor = true;
            btnNuevaMascota.Click += btnNuevaMascota_Click;
            // 
            // btnLeerMascotas
            // 
            btnLeerMascotas.Location = new Point(53, 321);
            btnLeerMascotas.Name = "btnLeerMascotas";
            btnLeerMascotas.Size = new Size(210, 52);
            btnLeerMascotas.TabIndex = 5;
            btnLeerMascotas.Text = "Leer Mascotas";
            btnLeerMascotas.UseVisualStyleBackColor = true;
            btnLeerMascotas.Click += btnLeerMascotas_Click;
            // 
            // button2
            // 
            button2.Location = new Point(53, 392);
            button2.Name = "button2";
            button2.Size = new Size(210, 63);
            button2.TabIndex = 6;
            button2.Text = "Guerdar mascotas";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(368, 41);
            label3.Name = "label3";
            label3.Size = new Size(111, 31);
            label3.TabIndex = 7;
            label3.Text = "Mascotas";
            // 
            // lstMascotas
            // 
            lstMascotas.FormattingEnabled = true;
            lstMascotas.ItemHeight = 31;
            lstMascotas.Location = new Point(368, 84);
            lstMascotas.Name = "lstMascotas";
            lstMascotas.Size = new Size(325, 407);
            lstMascotas.TabIndex = 8;
            lstMascotas.SelectedIndexChanged += lstMascotas_SelectedIndexChanged;
            // 
            // Form23Mascotas
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 517);
            Controls.Add(lstMascotas);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(btnLeerMascotas);
            Controls.Add(btnNuevaMascota);
            Controls.Add(txtRaza);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Form23Mascotas";
            Text = "Form23Mascotas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private TextBox txtRaza;
        private Label label2;
        private Button btnNuevaMascota;
        private Button btnLeerMascotas;
        private Button button2;
        private Label label3;
        private ListBox lstMascotas;
    }
}