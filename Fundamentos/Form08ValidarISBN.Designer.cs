namespace Fundamentos
{
    partial class Form08ValidarISBN
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
            txtISBN = new TextBox();
            btnValida = new Button();
            lblMensaje = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 32);
            label1.Name = "label1";
            label1.Size = new Size(166, 31);
            label1.TabIndex = 0;
            label1.Text = "Introduce ISBN";
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(47, 77);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(256, 38);
            txtISBN.TabIndex = 1;
            // 
            // btnValida
            // 
            btnValida.Location = new Point(134, 144);
            btnValida.Name = "btnValida";
            btnValida.Size = new Size(207, 58);
            btnValida.TabIndex = 2;
            btnValida.Text = "Validar ISBN";
            btnValida.UseVisualStyleBackColor = true;
            btnValida.Click += btnValida_Click;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(47, 235);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(76, 31);
            lblMensaje.TabIndex = 3;
            lblMensaje.Text = "label2";
            // 
            // Form08ValidarISBN
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 309);
            Controls.Add(lblMensaje);
            Controls.Add(btnValida);
            Controls.Add(txtISBN);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Form08ValidarISBN";
            Text = "Form08ValidarISBN";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtISBN;
        private Button btnValida;
        private Label lblMensaje;
    }
}