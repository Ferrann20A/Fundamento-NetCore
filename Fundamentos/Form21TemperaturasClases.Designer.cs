namespace Fundamentos
{
    partial class Form21TemperaturasClases
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
            lstTemperaturas = new ListBox();
            btnGenerarTemperaturas = new Button();
            btnMostrarDatos = new Button();
            label2 = new Label();
            txtTempMax = new TextBox();
            txtTempMin = new TextBox();
            label3 = new Label();
            txtMediaAnual = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 26);
            label1.Name = "label1";
            label1.Size = new Size(153, 31);
            label1.TabIndex = 0;
            label1.Text = "Temperaturas";
            // 
            // lstTemperaturas
            // 
            lstTemperaturas.FormattingEnabled = true;
            lstTemperaturas.ItemHeight = 31;
            lstTemperaturas.Location = new Point(62, 67);
            lstTemperaturas.Name = "lstTemperaturas";
            lstTemperaturas.Size = new Size(305, 407);
            lstTemperaturas.TabIndex = 1;
            // 
            // btnGenerarTemperaturas
            // 
            btnGenerarTemperaturas.Location = new Point(426, 26);
            btnGenerarTemperaturas.Name = "btnGenerarTemperaturas";
            btnGenerarTemperaturas.Size = new Size(277, 67);
            btnGenerarTemperaturas.TabIndex = 2;
            btnGenerarTemperaturas.Text = "Generar Temperaturas";
            btnGenerarTemperaturas.UseVisualStyleBackColor = true;
            btnGenerarTemperaturas.Click += btnGenerarTemperaturas_Click;
            // 
            // btnMostrarDatos
            // 
            btnMostrarDatos.Location = new Point(426, 112);
            btnMostrarDatos.Name = "btnMostrarDatos";
            btnMostrarDatos.Size = new Size(277, 57);
            btnMostrarDatos.TabIndex = 3;
            btnMostrarDatos.Text = "Mostrar datos";
            btnMostrarDatos.UseVisualStyleBackColor = true;
            btnMostrarDatos.Click += btnMostrarDatos_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(456, 183);
            label2.Name = "label2";
            label2.Size = new Size(230, 31);
            label2.TabIndex = 4;
            label2.Text = "Temperatura máxima";
            // 
            // txtTempMax
            // 
            txtTempMax.Location = new Point(518, 231);
            txtTempMax.Name = "txtTempMax";
            txtTempMax.Size = new Size(98, 38);
            txtTempMax.TabIndex = 5;
            // 
            // txtTempMin
            // 
            txtTempMin.Location = new Point(518, 333);
            txtTempMin.Name = "txtTempMin";
            txtTempMin.Size = new Size(98, 38);
            txtTempMin.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(456, 285);
            label3.Name = "label3";
            label3.Size = new Size(226, 31);
            label3.TabIndex = 6;
            label3.Text = "Temperatura mínima";
            // 
            // txtMediaAnual
            // 
            txtMediaAnual.Location = new Point(518, 436);
            txtMediaAnual.Name = "txtMediaAnual";
            txtMediaAnual.Size = new Size(98, 38);
            txtMediaAnual.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(499, 391);
            label4.Name = "label4";
            label4.Size = new Size(141, 31);
            label4.TabIndex = 8;
            label4.Text = "Media anual";
            // 
            // Form21TemperaturasClases
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 508);
            Controls.Add(txtMediaAnual);
            Controls.Add(label4);
            Controls.Add(txtTempMin);
            Controls.Add(label3);
            Controls.Add(txtTempMax);
            Controls.Add(label2);
            Controls.Add(btnMostrarDatos);
            Controls.Add(btnGenerarTemperaturas);
            Controls.Add(lstTemperaturas);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Form21TemperaturasClases";
            Text = "Form21TemperaturasClases";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstTemperaturas;
        private Button btnGenerarTemperaturas;
        private Button btnMostrarDatos;
        private Label label2;
        private TextBox txtTempMax;
        private TextBox txtTempMin;
        private Label label3;
        private TextBox txtMediaAnual;
        private Label label4;
    }
}