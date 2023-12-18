namespace Fundamentos
{
    partial class Form01SumarNumeros
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
            btnSuma = new Button();
            label1 = new Label();
            label2 = new Label();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // btnSuma
            // 
            btnSuma.Location = new Point(135, 113);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(139, 39);
            btnSuma.TabIndex = 0;
            btnSuma.Text = "Sumar Números";
            btnSuma.UseVisualStyleBackColor = true;
            btnSuma.Click += btnSuma_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 23);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 1;
            label1.Text = "Número 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 60);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 2;
            label2.Text = "Número 2";
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(148, 24);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(125, 27);
            txtNum1.TabIndex = 3;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(148, 60);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(125, 27);
            txtNum2.TabIndex = 4;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(378, 48);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(92, 20);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "lblResultado";
            // 
            // Form01SumarNumeros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 182);
            Controls.Add(lblResultado);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSuma);
            Name = "Form01SumarNumeros";
            Text = "Form01SumarNumeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSuma;
        private Label label1;
        private Label label2;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private Label lblResultado;
    }
}