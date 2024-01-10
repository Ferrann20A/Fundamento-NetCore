using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClases;

namespace Fundamentos
{
    public partial class Form20TestingClases : Form
    {
        public Form20TestingClases()
        {
            InitializeComponent();
        }

        private void btnCrearPersona_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.nombre = "Ferran";
            persona.apellidos = "Aguilar";
            persona.Edad = 20;
            persona.Nacionalidad = Paises.España;
            persona.Genero = TipoGenero.Masculino;
            persona.MetodoParametrosOpcionales(77);
            persona.MetodoParametrosOpcionales(88,99);
            persona.MetodoParametrosOpcionales(1,2,3);
            //Solamente queremos enviar el parametro 1 y 3
            persona.MetodoParametrosOpcionales(1,num3: 88);
            //persona.GetNombreCompleto();

            this.lstDatosClases.Items.Add(persona.GetNombreCompleto(true));
            this.lstDatosClases.Items.Add(persona.GetNombreCompleto());
            this.lstDatosClases.Items.Add("Edad: " + persona.Edad);
            this.lstDatosClases.Items.Add("Género: " + persona.Genero);
            this.lstDatosClases.Items.Add("Nacionalidad: " + persona.Nacionalidad);
        }
    }
}
