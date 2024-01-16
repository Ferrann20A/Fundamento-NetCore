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
            persona.MetodoParametrosOpcionales(88, 99);
            persona.MetodoParametrosOpcionales(1, 2, 3);
            //Solamente queremos enviar el parametro 1 y 3
            persona.MetodoParametrosOpcionales(1, num3: 88);
            //persona.GetNombreCompleto();
            persona.Domicilio = new Direccion("Calle Tajamar, 12", "Madrid");
            persona.DomicilioVacaciones = new Direccion("Calle Juerga, 12", "Marbella", 65872);
            this.lstDatosClases.Items.Add("Calle: " + persona.Domicilio.Calle);

            persona[0] = "Ojos azules";
            persona[1] = " Estiloso....";

            this.lstDatosClases.Items.Add("Descripción[0]: " + persona[0]);
            this.lstDatosClases.Items.Add("Descripción[1]: " + persona[1]);

            this.lstDatosClases.Items.Add(persona.GetNombreCompleto(true));
            this.lstDatosClases.Items.Add(persona.GetNombreCompleto());
            this.lstDatosClases.Items.Add("Edad: " + persona.Edad);
            this.lstDatosClases.Items.Add("Género: " + persona.Genero);
            this.lstDatosClases.Items.Add("Nacionalidad: " + persona.Nacionalidad);
        }

        private void btnCrearEmpleado_Click(object sender, EventArgs e)
        {
            Empleado emp = new Empleado();
            emp.nombre = "Empleado";
            emp.apellidos = "empleado";
            this.lstDatosClases.Items.Add(emp.ToString());
            //Al poner la propiedad SalarioMinimo (clase Empleado) como protected no nos permite
            //realizar lo siguiente:
            //emp.SalarioMinimo = 4000;
            this.lstDatosClases.Items.Add("Salario mínimo Empleado: " + emp.GetSalarioMinimo());
            this.lstDatosClases.Items.Add("Vacaciones Empleado: " + emp.GetDiasVacaciones());
            Director dir = new Director();
            dir.nombre = "Director";
            dir.apellidos = "dir";
            this.lstDatosClases.Items.Add(dir.ToString());
            this.lstDatosClases.Items.Add("Salario mínimo Director: " + dir.GetSalarioMinimo());
            this.lstDatosClases.Items.Add("Vacaciones Director: " + dir.GetDiasVacaciones());

        }
    }
}
