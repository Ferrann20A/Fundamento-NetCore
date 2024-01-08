namespace Fundamentos
{
    partial class Form09ValidarDNI
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
            txtDNI = new TextBox();
            btnValida = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 36);
            label1.Name = "label1";
            label1.Size = new Size(157, 31);
            label1.TabIndex = 0;
            label1.Text = "Introduce DNI";
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(53, 81);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(293, 38);
            txtDNI.TabIndex = 1;
            // 
            // btnValida
            // 
            btnValida.Location = new Point(109, 148);
            btnValida.Name = "btnValida";
            btnValida.Size = new Size(216, 62);
            btnValida.TabIndex = 2;
            btnValida.Text = "Validar DNI";
            btnValida.UseVisualStyleBackColor = true;
            btnValida.Click += btnValida_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(42, 257);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(141, 31);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "lblResultado";
            // 
            // Form09ValidarDNI
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 335);
            Controls.Add(lblResultado);
            Controls.Add(btnValida);
            Controls.Add(txtDNI);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 5, 5, 5);
            Name = "Form09ValidarDNI";
            Text = "Form09ValidarDNI";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDNI;
        private Button btnValida;
        private Label lblResultado;
    }
}