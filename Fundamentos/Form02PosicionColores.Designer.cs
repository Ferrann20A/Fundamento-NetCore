namespace Fundamentos
{
    partial class Form02PosicionColores
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
            txtValX = new TextBox();
            txtValY = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnPulsar = new Button();
            txtRojo = new TextBox();
            txtVerde = new TextBox();
            txtAzul = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnCambiaColor = new Button();
            SuspendLayout();
            // 
            // txtValX
            // 
            txtValX.Location = new Point(110, 36);
            txtValX.Name = "txtValX";
            txtValX.Size = new Size(125, 27);
            txtValX.TabIndex = 0;
            // 
            // txtValY
            // 
            txtValY.Location = new Point(110, 82);
            txtValY.Name = "txtValY";
            txtValY.Size = new Size(125, 27);
            txtValY.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 39);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 2;
            label1.Text = "Valor de x";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 82);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 3;
            label2.Text = "Valor de y";
            // 
            // btnPulsar
            // 
            btnPulsar.Location = new Point(299, 58);
            btnPulsar.Name = "btnPulsar";
            btnPulsar.Size = new Size(100, 34);
            btnPulsar.TabIndex = 4;
            btnPulsar.Text = "Púlsame";
            btnPulsar.UseVisualStyleBackColor = true;
            btnPulsar.Click += btnPulsar_Click;
            // 
            // txtRojo
            // 
            txtRojo.Location = new Point(110, 184);
            txtRojo.Name = "txtRojo";
            txtRojo.Size = new Size(125, 27);
            txtRojo.TabIndex = 5;
            // 
            // txtVerde
            // 
            txtVerde.Location = new Point(110, 233);
            txtVerde.Name = "txtVerde";
            txtVerde.Size = new Size(125, 27);
            txtVerde.TabIndex = 6;
            // 
            // txtAzul
            // 
            txtAzul.Location = new Point(110, 287);
            txtAzul.Name = "txtAzul";
            txtAzul.Size = new Size(125, 27);
            txtAzul.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 191);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 8;
            label3.Text = "Rojo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 233);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 9;
            label4.Text = "Verde";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 287);
            label5.Name = "label5";
            label5.Size = new Size(38, 20);
            label5.TabIndex = 10;
            label5.Text = "Azul";
            // 
            // btnCambiaColor
            // 
            btnCambiaColor.Location = new Point(299, 209);
            btnCambiaColor.Name = "btnCambiaColor";
            btnCambiaColor.Size = new Size(130, 74);
            btnCambiaColor.TabIndex = 11;
            btnCambiaColor.Text = "Cambiar el color del fondo";
            btnCambiaColor.UseVisualStyleBackColor = true;
            btnCambiaColor.Click += btnCambiaColor_Click;
            // 
            // Form02PosicionColores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 357);
            Controls.Add(btnCambiaColor);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtAzul);
            Controls.Add(txtVerde);
            Controls.Add(txtRojo);
            Controls.Add(btnPulsar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtValY);
            Controls.Add(txtValX);
            Name = "Form02PosicionColores";
            Text = "Form02PosicionColores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtValX;
        private TextBox txtValY;
        private Label label1;
        private Label label2;
        private Button btnPulsar;
        private TextBox txtRojo;
        private TextBox txtVerde;
        private TextBox txtAzul;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnCambiaColor;
    }
}