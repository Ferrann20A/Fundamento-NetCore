namespace Fundamentos
{
    partial class Form14Metodos
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
            txtNumero = new TextBox();
            btnDobleValor = new Button();
            btnDobleReferencia = new Button();
            lblResultado = new Label();
            btnObjetoReferencia = new Button();
            lblMouse = new Label();
            label2 = new Label();
            label3 = new Label();
            txtSoloNumeros = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 43);
            label1.Name = "label1";
            label1.Size = new Size(97, 31);
            label1.TabIndex = 0;
            label1.Text = "Número";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(34, 87);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(210, 38);
            txtNumero.TabIndex = 1;
            // 
            // btnDobleValor
            // 
            btnDobleValor.Location = new Point(34, 219);
            btnDobleValor.Name = "btnDobleValor";
            btnDobleValor.Size = new Size(192, 67);
            btnDobleValor.TabIndex = 2;
            btnDobleValor.Text = "Doble Valor";
            btnDobleValor.UseVisualStyleBackColor = true;
            btnDobleValor.Click += btnDobleValor_Click;
            // 
            // btnDobleReferencia
            // 
            btnDobleReferencia.Location = new Point(34, 311);
            btnDobleReferencia.Name = "btnDobleReferencia";
            btnDobleReferencia.Size = new Size(192, 80);
            btnDobleReferencia.TabIndex = 3;
            btnDobleReferencia.Text = "Doble Referencia";
            btnDobleReferencia.UseVisualStyleBackColor = true;
            btnDobleReferencia.Click += btnDobleReferencia_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(43, 152);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(141, 31);
            lblResultado.TabIndex = 4;
            lblResultado.Text = "lblResultado";
            lblResultado.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnObjetoReferencia
            // 
            btnObjetoReferencia.Location = new Point(34, 416);
            btnObjetoReferencia.Name = "btnObjetoReferencia";
            btnObjetoReferencia.Size = new Size(192, 80);
            btnObjetoReferencia.TabIndex = 5;
            btnObjetoReferencia.Text = "Objeto Referencia";
            btnObjetoReferencia.UseVisualStyleBackColor = true;
            btnObjetoReferencia.Click += btnObjetoReferencia_Click;
            // 
            // lblMouse
            // 
            lblMouse.BackColor = SystemColors.MenuHighlight;
            lblMouse.Location = new Point(390, 257);
            lblMouse.Name = "lblMouse";
            lblMouse.Size = new Size(508, 261);
            lblMouse.TabIndex = 6;
            lblMouse.Text = "lblMouse";
            lblMouse.MouseMove += lblMouse_MouseMove;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(418, 37);
            label2.Name = "label2";
            label2.Size = new Size(153, 31);
            label2.TabIndex = 7;
            label2.Text = "Solo números";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(418, 116);
            label3.Name = "label3";
            label3.Size = new Size(120, 31);
            label3.TabIndex = 8;
            label3.Text = "Solo letras";
            // 
            // txtSoloNumeros
            // 
            txtSoloNumeros.Location = new Point(594, 36);
            txtSoloNumeros.Name = "txtSoloNumeros";
            txtSoloNumeros.Size = new Size(304, 38);
            txtSoloNumeros.TabIndex = 9;
            txtSoloNumeros.KeyPress += txtSoloNumeros_KeyPress;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(594, 109);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(304, 38);
            textBox2.TabIndex = 10;
            // 
            // Form14Metodos
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 527);
            Controls.Add(textBox2);
            Controls.Add(txtSoloNumeros);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblMouse);
            Controls.Add(btnObjetoReferencia);
            Controls.Add(lblResultado);
            Controls.Add(btnDobleReferencia);
            Controls.Add(btnDobleValor);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Form14Metodos";
            Text = "Form14Metodos";
            FormClosed += Form14Metodos_FormClosed;
            Load += Form14Metodos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumero;
        private Button btnDobleValor;
        private Button btnDobleReferencia;
        private Label lblResultado;
        private Button btnObjetoReferencia;
        private Label lblMouse;
        private Label label2;
        private Label label3;
        private TextBox txtSoloNumeros;
        private TextBox textBox2;
    }
}