namespace Fundamentos
{
    partial class Form04DateTime
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
            txtFechaActual = new TextBox();
            chkCambiarFormato = new CheckBox();
            rdbDias = new RadioButton();
            rdbMeses = new RadioButton();
            rdbAnyos = new RadioButton();
            groupBox1 = new GroupBox();
            btnIncremento = new Button();
            txtIncremento = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtNuevaFecha = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 9);
            label1.Name = "label1";
            label1.Size = new Size(170, 38);
            label1.TabIndex = 0;
            label1.Text = "Fecha actual";
            // 
            // txtFechaActual
            // 
            txtFechaActual.Location = new Point(44, 61);
            txtFechaActual.Name = "txtFechaActual";
            txtFechaActual.Size = new Size(697, 43);
            txtFechaActual.TabIndex = 1;
            // 
            // chkCambiarFormato
            // 
            chkCambiarFormato.AutoSize = true;
            chkCambiarFormato.Location = new Point(44, 136);
            chkCambiarFormato.Name = "chkCambiarFormato";
            chkCambiarFormato.Size = new Size(332, 42);
            chkCambiarFormato.TabIndex = 2;
            chkCambiarFormato.Text = "Cambiar Formato Fecha";
            chkCambiarFormato.UseVisualStyleBackColor = true;
            chkCambiarFormato.CheckedChanged += chkCambiarFormato_CheckedChanged;
            // 
            // rdbDias
            // 
            rdbDias.AutoSize = true;
            rdbDias.Location = new Point(37, 59);
            rdbDias.Name = "rdbDias";
            rdbDias.Size = new Size(91, 42);
            rdbDias.TabIndex = 3;
            rdbDias.TabStop = true;
            rdbDias.Text = "Días";
            rdbDias.UseVisualStyleBackColor = true;
            // 
            // rdbMeses
            // 
            rdbMeses.AutoSize = true;
            rdbMeses.Location = new Point(37, 107);
            rdbMeses.Name = "rdbMeses";
            rdbMeses.Size = new Size(117, 42);
            rdbMeses.TabIndex = 4;
            rdbMeses.TabStop = true;
            rdbMeses.Text = "Meses";
            rdbMeses.UseVisualStyleBackColor = true;
            // 
            // rdbAnyos
            // 
            rdbAnyos.AutoSize = true;
            rdbAnyos.Location = new Point(37, 155);
            rdbAnyos.Name = "rdbAnyos";
            rdbAnyos.Size = new Size(100, 42);
            rdbAnyos.TabIndex = 5;
            rdbAnyos.TabStop = true;
            rdbAnyos.Text = "Años";
            rdbAnyos.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnIncremento);
            groupBox1.Controls.Add(txtIncremento);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(rdbMeses);
            groupBox1.Controls.Add(rdbAnyos);
            groupBox1.Controls.Add(rdbDias);
            groupBox1.Location = new Point(44, 195);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(581, 241);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Incrementar fecha";
            // 
            // btnIncremento
            // 
            btnIncremento.Location = new Point(286, 153);
            btnIncremento.Name = "btnIncremento";
            btnIncremento.Size = new Size(226, 54);
            btnIncremento.TabIndex = 8;
            btnIncremento.Text = "Incrementar";
            btnIncremento.UseVisualStyleBackColor = true;
            btnIncremento.Click += btnIncremento_Click;
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(286, 91);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(226, 43);
            txtIncremento.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(286, 39);
            label2.Name = "label2";
            label2.Size = new Size(158, 38);
            label2.TabIndex = 6;
            label2.Text = "Incremento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 470);
            label3.Name = "label3";
            label3.Size = new Size(177, 38);
            label3.TabIndex = 7;
            label3.Text = "Nueva fecha:";
            // 
            // txtNuevaFecha
            // 
            txtNuevaFecha.Location = new Point(227, 470);
            txtNuevaFecha.Name = "txtNuevaFecha";
            txtNuevaFecha.Size = new Size(567, 43);
            txtNuevaFecha.TabIndex = 8;
            // 
            // Form04DateTime
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 542);
            Controls.Add(txtNuevaFecha);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(chkCambiarFormato);
            Controls.Add(txtFechaActual);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "Form04DateTime";
            Text = "Form04DateTime";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFechaActual;
        private CheckBox chkCambiarFormato;
        private RadioButton rdbDias;
        private RadioButton rdbMeses;
        private RadioButton rdbAnyos;
        private GroupBox groupBox1;
        private Button btnIncremento;
        private TextBox txtIncremento;
        private Label label2;
        private Label label3;
        private TextBox txtNuevaFecha;
    }
}