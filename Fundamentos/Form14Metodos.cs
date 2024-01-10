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
    public partial class Form14Metodos : Form
    {
        public Form14Metodos()
        {
            InitializeComponent();
        }

        private void btnDobleValor_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(this.txtNumero.Text);
            this.GetDobleValor(numero);
            this.lblResultado.Text = numero.ToString();
        }

        //Recibimos el parametro wrapper por valor
        void GetDobleValor(int num)
        {
            num = num * 2;
        }

        private void btnObjetoReferencia_Click(object sender, EventArgs e)
        {
            this.cambiarColor(this.btnDobleReferencia);
        }

        void cambiarColor(Button boton)
        {
            boton.BackColor = Color.Yellow;
        }

        private void btnDobleReferencia_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(this.txtNumero.Text);
            //Tanto en el metodo como en la llamada hay que utilizar la palabra ref
            int doble = this.GetDobleOk(numero);
            //this.GetDobleReferencia(ref numero);
            this.lblResultado.Text = doble.ToString();
        }

        int GetDobleOk(int num)
        {
            int doble = num * 2;
            return doble;
        }

        void GetDobleReferencia(ref int num)
        {
            num = num * 2;
        }

        private void Form14Metodos_Load(object sender, EventArgs e)
        {

        }

        private void Form14Metodos_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void lblMouse_MouseMove(object sender, MouseEventArgs e)
        {
            this.lblMouse.Text = "X: " + e.X + ", Y: " + e.Y;
        }

        private void txtSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.lblResultado.Text = e.KeyChar.ToString();
            if (char.IsDigit(e.KeyChar) == false)
            {
                e.Handled = true;
            }
            //miralo en el onenote para dejarlo hecho
        }
    }
}
