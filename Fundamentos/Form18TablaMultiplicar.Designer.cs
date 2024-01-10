namespace Fundamentos
{
    partial class Form18TablaMultiplicar
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
            btnMostrarTabla = new Button();
            panel1 = new Panel();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 30);
            label1.Name = "label1";
            label1.Size = new Size(97, 31);
            label1.TabIndex = 0;
            label1.Text = "Número";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(45, 79);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(136, 38);
            txtNumero.TabIndex = 1;
            // 
            // btnMostrarTabla
            // 
            btnMostrarTabla.Location = new Point(45, 169);
            btnMostrarTabla.Name = "btnMostrarTabla";
            btnMostrarTabla.Size = new Size(197, 83);
            btnMostrarTabla.TabIndex = 2;
            btnMostrarTabla.Text = "Mostrar tabla";
            btnMostrarTabla.UseVisualStyleBackColor = true;
            btnMostrarTabla.Click += btnMostrarTabla_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(327, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(266, 404);
            panel1.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(64, 187);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(134, 38);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(64, 105);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(134, 38);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(64, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(134, 38);
            textBox1.TabIndex = 0;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(64, 252);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(134, 38);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(64, 322);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(134, 38);
            textBox5.TabIndex = 4;
            // 
            // Form18TablaMultiplicar
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 476);
            Controls.Add(panel1);
            Controls.Add(btnMostrarTabla);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Form18TablaMultiplicar";
            Text = "Form18TablaMultiplicar";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumero;
        private Button btnMostrarTabla;
        private Panel panel1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox5;
        private TextBox textBox4;
    }
}