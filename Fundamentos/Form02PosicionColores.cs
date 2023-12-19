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
    public partial class Form02PosicionColores : Form
    {
        public Form02PosicionColores()
        {
            InitializeComponent();
        }

        private void btnPulsar_Click(object sender, EventArgs e)
        {
            int x = int.Parse(this.txtValX.Text);
            int y = int.Parse(this.txtValY.Text);
            this.btnPulsar.Location = new Point(x, y);
        }

        private void btnCambiaColor_Click(object sender, EventArgs e)
        {
            int rojo = int.Parse(this.txtRojo.Text);
            int verde = int.Parse(this.txtVerde.Text);
            int azul = int.Parse(this.txtAzul.Text);
            if (rojo < 0 || rojo > 255)
            {
                MessageBox.Show("Debes introducir un número entre 0 y 255", 
                    "Error Message", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }else if (verde < 0 || verde > 255)
            {
                MessageBox.Show("Debes introducir un número entre 0 y 255",
                    "Error Message",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }else if (azul < 0 || azul > 255)
            {
                MessageBox.Show("Debes introducir un número entre 0 y 255",
                    "Error Message",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                this.BackColor = Color.FromArgb(rojo, verde, azul);
            }
        }
    }
}
