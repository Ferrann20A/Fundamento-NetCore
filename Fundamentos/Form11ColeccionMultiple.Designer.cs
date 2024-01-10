namespace Fundamentos
{
    partial class Form11ColeccionMultiple
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
            btnBorrar = new Button();
            btnEliminar = new Button();
            btnInsertar = new Button();
            txtElemento = new TextBox();
            lstElementos = new ListBox();
            label4 = new Label();
            lblIndiceSeleccionado = new Label();
            lblSeleccionado = new Label();
            label1 = new Label();
            btnSeleccionados = new Button();
            SuspendLayout();
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(394, 363);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(251, 50);
            btnBorrar.TabIndex = 17;
            btnBorrar.Text = "Borrar todo";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(394, 218);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(251, 50);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(394, 145);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(251, 50);
            btnInsertar.TabIndex = 15;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // txtElemento
            // 
            txtElemento.Location = new Point(394, 79);
            txtElemento.Name = "txtElemento";
            txtElemento.Size = new Size(251, 38);
            txtElemento.TabIndex = 14;
            // 
            // lstElementos
            // 
            lstElementos.FormattingEnabled = true;
            lstElementos.ItemHeight = 31;
            lstElementos.Location = new Point(31, 81);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new Size(226, 221);
            lstElementos.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(394, 45);
            label4.Name = "label4";
            label4.Size = new Size(182, 31);
            label4.TabIndex = 12;
            label4.Text = "Nuevo Elemento";
            // 
            // lblIndiceSeleccionado
            // 
            lblIndiceSeleccionado.AutoSize = true;
            lblIndiceSeleccionado.Location = new Point(31, 373);
            lblIndiceSeleccionado.Name = "lblIndiceSeleccionado";
            lblIndiceSeleccionado.Size = new Size(237, 31);
            lblIndiceSeleccionado.TabIndex = 11;
            lblIndiceSeleccionado.Text = "lblIndiceSeleccionado";
            // 
            // lblSeleccionado
            // 
            lblSeleccionado.AutoSize = true;
            lblSeleccionado.Location = new Point(31, 327);
            lblSeleccionado.Name = "lblSeleccionado";
            lblSeleccionado.Size = new Size(175, 31);
            lblSeleccionado.TabIndex = 10;
            lblSeleccionado.Text = "lblSeleccionado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 37);
            label1.Name = "label1";
            label1.Size = new Size(120, 31);
            label1.TabIndex = 9;
            label1.Text = "Elementos";
            // 
            // btnSeleccionados
            // 
            btnSeleccionados.Location = new Point(394, 291);
            btnSeleccionados.Name = "btnSeleccionados";
            btnSeleccionados.Size = new Size(251, 55);
            btnSeleccionados.TabIndex = 18;
            btnSeleccionados.Text = "Seleccionados";
            btnSeleccionados.UseVisualStyleBackColor = true;
            btnSeleccionados.Click += btnSeleccionados_Click;
            // 
            // Form11ColeccionMultiple
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 447);
            Controls.Add(btnSeleccionados);
            Controls.Add(btnBorrar);
            Controls.Add(btnEliminar);
            Controls.Add(btnInsertar);
            Controls.Add(txtElemento);
            Controls.Add(lstElementos);
            Controls.Add(label4);
            Controls.Add(lblIndiceSeleccionado);
            Controls.Add(lblSeleccionado);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Form11ColeccionMultiple";
            Text = "Form11ColeccionMultiple";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBorrar;
        private Button btnEliminar;
        private Button btnInsertar;
        private TextBox txtElemento;
        private ListBox lstElementos;
        private Label label4;
        private Label lblIndiceSeleccionado;
        private Label lblSeleccionado;
        private Label label1;
        private Button btnSeleccionados;
    }
}