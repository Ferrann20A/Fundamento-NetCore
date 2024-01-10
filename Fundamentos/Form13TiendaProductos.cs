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
    public partial class Form13TiendaProductos : Form
    {
        public Form13TiendaProductos()
        {
            InitializeComponent();
            this.lstProductos.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string producto = this.txtProducto.Text;

            if (!lstProductos.Items.Contains(producto))
            {
                this.lstProductos.Items.Add(producto);
            }
            else
            {
                this.lstProductos.SelectedIndex = this.lstProductos.Items.IndexOf(producto);
                this.lstProductos.Focus();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si hay elementos seleccionados en el ListBox
            if (lstProductos.SelectedItems.Count > 0)
            {
                // Eliminar cada elemento seleccionado
                foreach (var selectedItem in lstProductos.SelectedItems.Cast<string>().ToList())
                {
                    lstProductos.Items.Remove(selectedItem);
                }
            }
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            this.lstProductos.Items.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.lstProductos.SelectedIndex != -1)
            {
                int indiceSeleccionado = this.lstProductos.SelectedIndex;
                this.lstProductos.Items[indiceSeleccionado] = this.txtProducto.Text;
            }
        }

        private void btnSeleccionados_Click(object sender, EventArgs e)
        {
            int numSeleccionados = this.lstProductos.SelectedIndices.Count;
            for (int i = numSeleccionados - 1; i >= 0; i--)
            {
                int indiceSeleccionado = this.lstProductos.SelectedIndices[i];
                string productoSeleccionado = this.lstProductos.SelectedItems[i].ToString();
                this.lstAlmacen.Items.Add(productoSeleccionado);
                this.lstProductos.Items.RemoveAt(indiceSeleccionado);
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            foreach (string producto in this.lstProductos.Items)
            {
                this.lstAlmacen.Items.Add(producto);
            }
            this.lstProductos.Items.Clear();
        }

        private void btSubir_Click(object sender, EventArgs e)
        {
            int indice = this.lstAlmacen.SelectedIndex;
            string producto = this.lstAlmacen.SelectedItem.ToString();
            this.lstAlmacen.Items.RemoveAt(indice);
            this.lstAlmacen.Items.Insert(indice - 1, producto);
            this.lstAlmacen.SelectedIndex = indice - 1;
        }

        private void btnBajar_Click(object sender, EventArgs e)
        {
            int indice = this.lstAlmacen.SelectedIndex;
            string producto = this.lstAlmacen.SelectedItem.ToString();
            this.lstAlmacen.Items.RemoveAt(indice);
            this.lstAlmacen.Items.Insert(indice + 1, producto);
            this.lstAlmacen.SelectedIndex = indice + 1;
        }

        private void lstAlmacen_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = this.lstAlmacen.SelectedIndex;
            if (indice == 0)
            {
                this.btSubir.Enabled = false;
            }
            else
            {
                this.btSubir.Enabled = true;
            }
            if (indice == this.lstAlmacen.Items.Count - 1)
            {
                this.btnBajar.Enabled = false;
            }
            else
            {
                this.btnBajar.Enabled = true;
            }
        }
    }
}
