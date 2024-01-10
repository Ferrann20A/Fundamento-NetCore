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
    public partial class Form18TablaMultiplicar : Form
    {
        List<TextBox> cajas;
        public Form18TablaMultiplicar()
        {
            InitializeComponent();
            this.cajas = new List<TextBox>();
            foreach (TextBox txt in this.panel1.Controls)
            {
                this.cajas.Add(txt);
            }

            //Este metodo nos permite dar la vuelta a nuestra coleccion
            this.cajas.Reverse();
        }

        private void btnMostrarTabla_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(this.txtNumero.Text);
            for (int i = 0; i< this.cajas.Count; i++)
            {
                int operacion = numero * (i + 1);
                this.cajas[i].Text = operacion.ToString();
            }
        }
    }
}
