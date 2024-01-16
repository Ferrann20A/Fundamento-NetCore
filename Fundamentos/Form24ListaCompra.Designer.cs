namespace Fundamentos
{
    partial class Form24ListaCompra
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
            lstProductos = new ListBox();
            label3 = new Label();
            btnGuardarProducto = new Button();
            btnLeerProductos = new Button();
            btnNuevoProducto = new Button();
            txtCantidad = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lstProductos
            // 
            lstProductos.FormattingEnabled = true;
            lstProductos.ItemHeight = 31;
            lstProductos.Location = new Point(397, 55);
            lstProductos.Name = "lstProductos";
            lstProductos.Size = new Size(325, 407);
            lstProductos.TabIndex = 17;
            lstProductos.SelectedIndexChanged += lstProductos_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(397, 12);
            label3.Name = "label3";
            label3.Size = new Size(117, 31);
            label3.TabIndex = 16;
            label3.Text = "Productos";
            // 
            // btnGuardarProducto
            // 
            btnGuardarProducto.Location = new Point(82, 363);
            btnGuardarProducto.Name = "btnGuardarProducto";
            btnGuardarProducto.Size = new Size(210, 85);
            btnGuardarProducto.TabIndex = 15;
            btnGuardarProducto.Text = "Guardar Productos";
            btnGuardarProducto.UseVisualStyleBackColor = true;
            btnGuardarProducto.Click += btnGuardarProducto_Click;
            // 
            // btnLeerProductos
            // 
            btnLeerProductos.Location = new Point(82, 292);
            btnLeerProductos.Name = "btnLeerProductos";
            btnLeerProductos.Size = new Size(210, 52);
            btnLeerProductos.TabIndex = 14;
            btnLeerProductos.Text = "Leer Productos";
            btnLeerProductos.UseVisualStyleBackColor = true;
            btnLeerProductos.Click += btnLeerProductos_Click;
            // 
            // btnNuevoProducto
            // 
            btnNuevoProducto.Location = new Point(82, 220);
            btnNuevoProducto.Name = "btnNuevoProducto";
            btnNuevoProducto.Size = new Size(210, 52);
            btnNuevoProducto.TabIndex = 13;
            btnNuevoProducto.Text = "Nueva Producto";
            btnNuevoProducto.UseVisualStyleBackColor = true;
            btnNuevoProducto.Click += btnNuevoProducto_Click;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(82, 159);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(210, 38);
            txtCantidad.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 116);
            label2.Name = "label2";
            label2.Size = new Size(107, 31);
            label2.TabIndex = 11;
            label2.Text = "Cantidad";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(82, 55);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(210, 38);
            txtNombre.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 12);
            label1.Name = "label1";
            label1.Size = new Size(198, 31);
            label1.TabIndex = 9;
            label1.Text = "Nombre producto";
            // 
            // Form24ListaCompra
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 475);
            Controls.Add(lstProductos);
            Controls.Add(label3);
            Controls.Add(btnGuardarProducto);
            Controls.Add(btnLeerProductos);
            Controls.Add(btnNuevoProducto);
            Controls.Add(txtCantidad);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Form24ListaCompra";
            Text = "Form24ListaCompra";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstProductos;
        private Label label3;
        private Button btnGuardarProducto;
        private Button btnLeerProductos;
        private Button btnNuevoProducto;
        private TextBox txtCantidad;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
    }
}