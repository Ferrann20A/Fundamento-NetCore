using System;
using System.Collections;
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
    public partial class Form15ArrayList : Form
    {
        public Form15ArrayList()
        {
            InitializeComponent();

            //this.button1.Click += Button1_Click;

            //Declaramos una coleccion generica
            List<Button> botones = new List<Button>();
            botones.Add(this.button1);
            botones.Add(this.button2);
            botones.Add(this.button3);
            //accedemos directamente a las propiedades del objeto
            botones[1].BackColor = Color.LightBlue;



            //Coleccion no tipada
            ArrayList coleccion = new ArrayList();
            coleccion.Add(this.button1);
            coleccion.Add(this.button2);
            coleccion.Add(this.button3);
            //Añadimos el textbox a la coleccion
            coleccion.Add(textBox1);
            //Si intentamos acceder a las propiedades, no podremos
            //Debemos realizar el casting para poder aplicar sus propiedades
            ((Button)coleccion[0]).Text = "Soy un botón";
            //Mediante la extracción, podemos recorrer todos los elementos de una
            //coleccion utilizando una clase en comun
            //foreach (Button btn in coleccion)
            //{
            //    btn.BackColor = Color.Yellow;
            //}

            //Si tenemos objetos que no sean de la misma familia directa, debemos
            //encontrar su familia en comun mediante abstraccion
            foreach(Control control in coleccion)
            {
                control.BackColor = Color.LightGreen;
                //Dentro de la abstraccion, podemos convertir a su clase
                //base para aplicar sus propiedades o metodos
                //Deseamos utilizar el metodo Paste() del contro TextBox
                if(control is TextBox)
                {
                    //realizamos un casting para aplicar sobre el objeto
                    ((TextBox)control).Paste();
                }
            }
        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
