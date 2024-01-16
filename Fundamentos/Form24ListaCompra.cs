using ProyectoClases.Helpers;
using ProyectoClases.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form24ListaCompra : Form
    {
        HelperProductos helper;
        public Form24ListaCompra()
        {
            InitializeComponent();
            this.helper = new HelperProductos();
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            Producto p = new Producto();
            p.Nombre = this.txtNombre.Text;
            p.Cantidad = this.txtCantidad.Text;
            this.helper.Productos.Add(p);
            this.DibujarProductosListBox();
        }

        private void DibujarProductosListBox()
        {
            this.lstProductos.Items.Clear();
            foreach (Producto producto in this.helper.Productos)
            {
                this.lstProductos.Items.Add(producto.Nombre + ", Cantidad: " + producto.Cantidad);
            }
        }

        private async void btnLeerProductos_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                await this.helper.ReadProductosAsync(path);
                this.DibujarProductosListBox();
            }
        }

        private async void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            if (svf.ShowDialog() == DialogResult.OK)
            {
                string path = svf.FileName;
                await this.helper.WriteProductosAsync(path);
                MessageBox.Show("Productos almacenados");
            }
        }

        private void lstProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSeleccionado = this.lstProductos.SelectedIndex;
            if (indiceSeleccionado == -1)
            {
                Producto p = new Producto();
                this.txtNombre.Text = p.Nombre;
                this.txtCantidad.Text = p.Cantidad;
            }
        }
    }
}
