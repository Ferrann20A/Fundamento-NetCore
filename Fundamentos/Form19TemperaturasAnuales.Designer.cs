namespace Fundamentos
{
    partial class Form19TemperaturasAnuales
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
            btnGenerarMeses = new Button();
            btnMostrarDatos = new Button();
            label2 = new Label();
            txtTempMax = new TextBox();
            txtTempMin = new TextBox();
            label3 = new Label();
            txtMediaAnual = new TextBox();
            label4 = new Label();
            lstTemperaturas = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 9);
            label1.Name = "label1";
            label1.Size = new Size(79, 31);
            label1.TabIndex = 0;
            label1.Text = "Meses";
            // 
            // btnGenerarMeses
            // 
            btnGenerarMeses.Location = new Point(416, 25);
            btnGenerarMeses.Name = "btnGenerarMeses";
            btnGenerarMeses.Size = new Size(213, 64);
            btnGenerarMeses.TabIndex = 1;
            btnGenerarMeses.Text = "Generar meses";
            btnGenerarMeses.UseVisualStyleBackColor = true;
            btnGenerarMeses.Click += btnGenerarMeses_Click;
            // 
            // btnMostrarDatos
            // 
            btnMostrarDatos.Location = new Point(416, 107);
            btnMostrarDatos.Name = "btnMostrarDatos";
            btnMostrarDatos.Size = new Size(213, 53);
            btnMostrarDatos.TabIndex = 2;
            btnMostrarDatos.Text = "Mostrar datos";
            btnMostrarDatos.UseVisualStyleBackColor = true;
            btnMostrarDatos.Click += btnMostrarDatos_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(403, 211);
            label2.Name = "label2";
            label2.Size = new Size(230, 31);
            label2.TabIndex = 3;
            label2.Text = "Temperatura máxima";
            // 
            // txtTempMax
            // 
            txtTempMax.Location = new Point(468, 256);
            txtTempMax.Name = "txtTempMax";
            txtTempMax.Size = new Size(98, 38);
            txtTempMax.TabIndex = 4;
            // 
            // txtTempMin
            // 
            txtTempMin.Location = new Point(468, 354);
            txtTempMin.Name = "txtTempMin";
            txtTempMin.Size = new Size(98, 38);
            txtTempMin.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(403, 309);
            label3.Name = "label3";
            label3.Size = new Size(226, 31);
            label3.TabIndex = 5;
            label3.Text = "Temperatura minima\r\n";
            // 
            // txtMediaAnual
            // 
            txtMediaAnual.Location = new Point(468, 461);
            txtMediaAnual.Name = "txtMediaAnual";
            txtMediaAnual.Size = new Size(98, 38);
            txtMediaAnual.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(442, 414);
            label4.Name = "label4";
            label4.Size = new Size(141, 31);
            label4.TabIndex = 7;
            label4.Text = "Media anual";
            // 
            // lstTemperaturas
            // 
            lstTemperaturas.FormattingEnabled = true;
            lstTemperaturas.ItemHeight = 31;
            lstTemperaturas.Location = new Point(33, 52);
            lstTemperaturas.Name = "lstTemperaturas";
            lstTemperaturas.Size = new Size(304, 469);
            lstTemperaturas.TabIndex = 9;
            // 
            // Form19TemperaturasAnuales
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 543);
            Controls.Add(lstTemperaturas);
            Controls.Add(txtMediaAnual);
            Controls.Add(label4);
            Controls.Add(txtTempMin);
            Controls.Add(label3);
            Controls.Add(txtTempMax);
            Controls.Add(label2);
            Controls.Add(btnMostrarDatos);
            Controls.Add(btnGenerarMeses);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Form19TemperaturasAnuales";
            Text = "Form19TemperaturasAnuales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnGenerarMeses;
        private Button btnMostrarDatos;
        private Label label2;
        private TextBox txtTempMax;
        private TextBox txtTempMin;
        private Label label3;
        private TextBox txtMediaAnual;
        private Label label4;
        private ListBox lstTemperaturas;
    }
}