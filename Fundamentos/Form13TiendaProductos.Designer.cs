namespace Fundamentos
{
    partial class Form13TiendaProductos
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
            txtProducto = new TextBox();
            btnInsertar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnBorrarTodo = new Button();
            label2 = new Label();
            lstProductos = new ListBox();
            btnSeleccionados = new Button();
            btnTodos = new Button();
            lstAlmacen = new ListBox();
            label3 = new Label();
            btSubir = new Button();
            btnBajar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(107, 31);
            label1.TabIndex = 0;
            label1.Text = "Producto";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(36, 76);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(197, 38);
            txtProducto.TabIndex = 1;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(36, 141);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(197, 61);
            btnInsertar.TabIndex = 2;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(36, 214);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(197, 61);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(36, 288);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(197, 61);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.Location = new Point(36, 373);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(197, 61);
            btnBorrarTodo.TabIndex = 5;
            btnBorrarTodo.Text = "Borrar todos";
            btnBorrarTodo.UseVisualStyleBackColor = true;
            btnBorrarTodo.Click += btnBorrarTodo_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(285, 30);
            label2.Name = "label2";
            label2.Size = new Size(83, 31);
            label2.TabIndex = 6;
            label2.Text = "Tienda";
            // 
            // lstProductos
            // 
            lstProductos.FormattingEnabled = true;
            lstProductos.ItemHeight = 31;
            lstProductos.Location = new Point(285, 76);
            lstProductos.Name = "lstProductos";
            lstProductos.Size = new Size(243, 376);
            lstProductos.TabIndex = 7;
            // 
            // btnSeleccionados
            // 
            btnSeleccionados.Location = new Point(546, 157);
            btnSeleccionados.Name = "btnSeleccionados";
            btnSeleccionados.Size = new Size(109, 45);
            btnSeleccionados.TabIndex = 8;
            btnSeleccionados.Text = "Seleccionado";
            btnSeleccionados.UseVisualStyleBackColor = true;
            btnSeleccionados.Click += btnSeleccionados_Click;
            // 
            // btnTodos
            // 
            btnTodos.Location = new Point(546, 246);
            btnTodos.Name = "btnTodos";
            btnTodos.Size = new Size(109, 45);
            btnTodos.TabIndex = 9;
            btnTodos.Text = "Todos";
            btnTodos.UseVisualStyleBackColor = true;
            btnTodos.Click += btnTodos_Click;
            // 
            // lstAlmacen
            // 
            lstAlmacen.FormattingEnabled = true;
            lstAlmacen.ItemHeight = 31;
            lstAlmacen.Location = new Point(675, 76);
            lstAlmacen.Name = "lstAlmacen";
            lstAlmacen.Size = new Size(240, 376);
            lstAlmacen.TabIndex = 10;
            lstAlmacen.SelectedIndexChanged += lstAlmacen_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(675, 30);
            label3.Name = "label3";
            label3.Size = new Size(117, 31);
            label3.TabIndex = 11;
            label3.Text = "Productos";
            // 
            // btSubir
            // 
            btSubir.Location = new Point(958, 149);
            btSubir.Name = "btSubir";
            btSubir.Size = new Size(116, 61);
            btSubir.TabIndex = 12;
            btSubir.Text = "Subir";
            btSubir.UseVisualStyleBackColor = true;
            btSubir.Click += btSubir_Click;
            // 
            // btnBajar
            // 
            btnBajar.Location = new Point(958, 238);
            btnBajar.Name = "btnBajar";
            btnBajar.Size = new Size(116, 61);
            btnBajar.TabIndex = 13;
            btnBajar.Text = "Bajar";
            btnBajar.UseVisualStyleBackColor = true;
            btnBajar.Click += btnBajar_Click;
            // 
            // Form13TiendaProductos
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 540);
            Controls.Add(btnBajar);
            Controls.Add(btSubir);
            Controls.Add(label3);
            Controls.Add(lstAlmacen);
            Controls.Add(btnTodos);
            Controls.Add(btnSeleccionados);
            Controls.Add(lstProductos);
            Controls.Add(label2);
            Controls.Add(btnBorrarTodo);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnInsertar);
            Controls.Add(txtProducto);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form13TiendaProductos";
            Text = "Form13TiendaProductos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtProducto;
        private Button btnInsertar;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnBorrarTodo;
        private Label label2;
        private ListBox lstProductos;
        private Button btnSeleccionados;
        private Button btnTodos;
        private ListBox lstAlmacen;
        private Label label3;
        private Button btSubir;
        private Button btnBajar;
    }
}