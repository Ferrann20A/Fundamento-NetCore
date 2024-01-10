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
    public partial class Form11ColeccionMultiple : Form
    {
        public Form11ColeccionMultiple()
        {
            InitializeComponent();
            //Cambiamos el select a multiple
            this.lstElementos.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string elem = this.txtElemento.Text;
            this.lstElementos.Items.Add(elem);
            this.txtElemento.Focus();
            this.txtElemento.SelectAll();
        }

        private void btnSeleccionados_Click(object sender, EventArgs e)
        {
            string indices = "";
            foreach (int indice in this.lstElementos.SelectedIndices)
            {
                indices += indice + ",";
            }
            this.lblIndiceSeleccionado.Text = indices.Trim(',');
            string items = "";
            foreach (string elem in this.lstElementos.SelectedItems)
            {
                items += elem + ",";
            }
            this.lblSeleccionado.Text = items.Trim(',');

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            this.lstElementos.Items.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Al eliminar multiples elementos de una coleccion siempre
            //debemos hacerlo desde el ultimo al primero por el 
            //reposicionamiento de los indices
            int numSeleccionados = this.lstElementos.SelectedIndices.Count;
            //Recorremos los indices seleccionados
            for (int i = numSeleccionados - 1; i >= 0; i--)
            {
                //Recuperamos cada indice
                int indice = this.lstElementos.SelectedIndices[i];
                //Eliminamos cada elemento por su indice de la coleccion
                this.lstElementos.Items.RemoveAt(indice);
            }
        }
    }
}
