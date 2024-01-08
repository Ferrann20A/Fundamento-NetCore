namespace Fundamentos
{
    partial class Form10ColeccionesGrafica
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
            lblSeleccionado = new Label();
            lblIndiceSeleccionado = new Label();
            label4 = new Label();
            lstElementos = new ListBox();
            txtElemento = new TextBox();
            btnInsertar = new Button();
            btnEliminar = new Button();
            btnBorrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 33);
            label1.Name = "label1";
            label1.Size = new Size(120, 31);
            label1.TabIndex = 0;
            label1.Text = "Elementos";
            // 
            // lblSeleccionado
            // 
            lblSeleccionado.AutoSize = true;
            lblSeleccionado.Location = new Point(49, 323);
            lblSeleccionado.Name = "lblSeleccionado";
            lblSeleccionado.Size = new Size(175, 31);
            lblSeleccionado.TabIndex = 1;
            lblSeleccionado.Text = "lblSeleccionado";
            // 
            // lblIndiceSeleccionado
            // 
            lblIndiceSeleccionado.AutoSize = true;
            lblIndiceSeleccionado.Location = new Point(49, 369);
            lblIndiceSeleccionado.Name = "lblIndiceSeleccionado";
            lblIndiceSeleccionado.Size = new Size(237, 31);
            lblIndiceSeleccionado.TabIndex = 2;
            lblIndiceSeleccionado.Text = "lblIndiceSeleccionado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(412, 41);
            label4.Name = "label4";
            label4.Size = new Size(182, 31);
            label4.TabIndex = 3;
            label4.Text = "Nuevo Elemento";
            // 
            // lstElementos
            // 
            lstElementos.FormattingEnabled = true;
            lstElementos.ItemHeight = 31;
            lstElementos.Location = new Point(49, 77);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new Size(183, 221);
            lstElementos.TabIndex = 4;
            lstElementos.SelectedIndexChanged += lstElementos_SelectedIndexChanged;
            // 
            // txtElemento
            // 
            txtElemento.Location = new Point(412, 75);
            txtElemento.Name = "txtElemento";
            txtElemento.Size = new Size(251, 38);
            txtElemento.TabIndex = 5;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(412, 141);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(251, 50);
            btnInsertar.TabIndex = 6;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(412, 214);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(251, 50);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(412, 283);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(251, 50);
            btnBorrar.TabIndex = 8;
            btnBorrar.Text = "Borrar todo";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // Form10ColeccionesGrafica
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 437);
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
            Name = "Form10ColeccionesGrafica";
            Text = "Form10ColeccionesGrafica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblSeleccionado;
        private Label lblIndiceSeleccionado;
        private Label label4;
        private ListBox lstElementos;
        private TextBox txtElemento;
        private Button btnInsertar;
        private Button btnEliminar;
        private Button btnBorrar;
    }
}