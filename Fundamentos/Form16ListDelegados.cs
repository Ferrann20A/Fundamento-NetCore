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
    public partial class Form16ListDelegados : Form
    {
        //Las colecciones se seuelen declarar a nivel de clase por si necesitamos
        //su uso
        List<Button> botones;
        int contador;
        public Form16ListDelegados()
        {
            InitializeComponent();
            //Queremos incluir todos los botones dentro de una coleccion
            //Posteriormente, recorrer dicha coleccion y delegar su evento click
            //Dentro de Forms tenemos una propiedad llamada controls que contiene todos
            //los controles del formulario, dicha propiedad funciona por container, es decir,
            //si tenemos un groupbox, debemos recorrer Controls del contenedor GroupBox
            //this.button1.Click += BotonPulsado;
            //this.button2.Click += BotonPulsado;
            this.botones = new List<Button>();
            this.contador = 0;
            foreach (Control control in this.Controls)
            {
                //Debemos preguntar si vienen botones
                if (control is Button)
                {
                    //Almacenamos nuestros botones
                    botones.Add((Button)control);
                }
            }
            //A continuacion ya trabajamos con nuestra coleccion
            //Recorremos todos los botones y los asociamos al evento
            foreach (Button btn in botones)
            {
                btn.Click += BotonPulsado;
            }
        }

        void BotonPulsado(object sender, EventArgs e)
        {
            this.contador += 1;
            this.txtContador.Text = "Contador : " + this.contador;
            //Cuando pulsemos cualquier boton quiero cambiar su color
            //sender Es el objeto que ha realizado la llamada
            Button boton = (Button)sender;
            boton.BackColor = Color.Coral;

        }
    }
}
