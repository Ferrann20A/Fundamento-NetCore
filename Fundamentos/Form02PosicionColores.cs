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
            this.BackColor = Color.FromArgb(rojo, verde, azul);
        }
    }
}
