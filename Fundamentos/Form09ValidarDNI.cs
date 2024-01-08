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
    public partial class Form09ValidarDNI : Form
    {
        public Form09ValidarDNI()
        {
            InitializeComponent();
        }

        private void btnValida_Click(object sender, EventArgs e)
        {
            string dni = this.txtDNI.Text;
            char letraDni = dni[dni.Length - 1];
            string soloNumeros = dni.Substring(0, dni.Length - 1);
            int dniNumber = int.Parse(soloNumeros);
            int resultado = (dniNumber - ((dniNumber / 23) * 23));

            string secueciaLetras = "TRWAGMYFPDXBNJZSQVHLCKET";
            char letraValidacion = secueciaLetras[resultado];
            if(letraDni == letraValidacion)
            {
                this.lblResultado.Text = "DNI Correcto!!!";
            }
            else
            {
                this.lblResultado.Text = "Incorrecto, su letra es " + letraValidacion;
            }
        }
    }
}
