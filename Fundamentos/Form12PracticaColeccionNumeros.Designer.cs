namespace Fundamentos
{
    partial class Form12PracticaColeccionNumeros
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
            lstNumeros = new ListBox();
            btnGenerar = new Button();
            btnMostrarDatos = new Button();
            label2 = new Label();
            txtSuma = new TextBox();
            txtSumaPares = new TextBox();
            label3 = new Label();
            txtSumaImpares = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 23);
            label1.Name = "label1";
            label1.Size = new Size(107, 31);
            label1.TabIndex = 0;
            label1.Text = "Números";
            // 
            // lstNumeros
            // 
            lstNumeros.FormattingEnabled = true;
            lstNumeros.ItemHeight = 31;
            lstNumeros.Location = new Point(31, 69);
            lstNumeros.Name = "lstNumeros";
            lstNumeros.Size = new Size(178, 252);
            lstNumeros.TabIndex = 1;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(285, 36);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(185, 54);
            btnGenerar.TabIndex = 2;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // btnMostrarDatos
            // 
            btnMostrarDatos.Location = new Point(285, 107);
            btnMostrarDatos.Name = "btnMostrarDatos";
            btnMostrarDatos.Size = new Size(185, 54);
            btnMostrarDatos.TabIndex = 3;
            btnMostrarDatos.Text = "Mostrar Datos";
            btnMostrarDatos.UseVisualStyleBackColor = true;
            btnMostrarDatos.Click += btnMostrarDatos_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(228, 208);
            label2.Name = "label2";
            label2.Size = new Size(71, 31);
            label2.TabIndex = 4;
            label2.Text = "Suma";
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(323, 208);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(147, 38);
            txtSuma.TabIndex = 5;
            // 
            // txtSumaPares
            // 
            txtSumaPares.Location = new Point(323, 267);
            txtSumaPares.Name = "txtSumaPares";
            txtSumaPares.Size = new Size(147, 38);
            txtSumaPares.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(228, 267);
            label3.Name = "label3";
            label3.Size = new Size(68, 31);
            label3.TabIndex = 6;
            label3.Text = "Pares";
            // 
            // txtSumaImpares
            // 
            txtSumaImpares.Location = new Point(323, 328);
            txtSumaImpares.Name = "txtSumaImpares";
            txtSumaImpares.Size = new Size(147, 38);
            txtSumaImpares.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(221, 328);
            label4.Name = "label4";
            label4.Size = new Size(96, 31);
            label4.TabIndex = 8;
            label4.Text = "Impares";
            // 
            // Form12PracticaColeccionNumeros
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 399);
            Controls.Add(txtSumaImpares);
            Controls.Add(label4);
            Controls.Add(txtSumaPares);
            Controls.Add(label3);
            Controls.Add(txtSuma);
            Controls.Add(label2);
            Controls.Add(btnMostrarDatos);
            Controls.Add(btnGenerar);
            Controls.Add(lstNumeros);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Form12PracticaColeccionNumeros";
            Text = "Form12PracticaColeccionNumeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstNumeros;
        private Button btnGenerar;
        private Button btnMostrarDatos;
        private Label label2;
        private TextBox txtSuma;
        private TextBox txtSumaPares;
        private Label label3;
        private TextBox txtSumaImpares;
        private Label label4;
    }
}