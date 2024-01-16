using ProyectoClases.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form22Files : Form
    {
        //HelperFiles helper;
        public Form22Files()
        {
            InitializeComponent();
        }

        private async void btnReadFile_Click(object sender, EventArgs e)
        {
            //OBJETO PARA SELECCIONAR EL FICHERO
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //Recuperamos la ruta del fichero
                string path = ofd.FileName;
                string data = await HelperFiles.ReadFileAsync(path);
                this.DibujarNombresListBox(data);
            }
        }

        //Cuando leamos el fichero, pintamos los nombres en el listBox
        public void DibujarNombresListBox(string data)
        {
            //LUCIA,ADRIAN,MARIA
            string[] nombres = data.Split(',');
            this.lstNombres.Items.Clear();
            foreach (string name in nombres)
            {
                this.lstNombres.Items.Add(name);
            }
        }

        private void btnNuevoNombre_Click(object sender, EventArgs e)
        {
            this.lstNombres.Items.Add(this.txtNombre.Text);
        }

        private async void btnWriteFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            if (svf.ShowDialog() == DialogResult.OK)
            {
                string path = svf.FileName;
                string data = this.GetNombresListBox();
                await HelperFiles.WriteFileAsync(path, data);
                MessageBox.Show("Datos almacenados");
            }
        }

        public string GetNombresListBox()
        {
            string data = "";
            foreach (string name in this.lstNombres.Items)
            {
                data += name + ",";
            }
            data = data.TrimEnd(',');
            return data;
        }
    }
}
