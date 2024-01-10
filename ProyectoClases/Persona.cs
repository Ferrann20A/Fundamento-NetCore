using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{

    public enum Paises { España, Francia, Alemania, Andorra, Portugal, Suiza }
    public enum TipoGenero { Masculino, Femenino }
    public class Persona
    {
        #region PROPIEDADES

        public string nombre { get; set; }
        public string apellidos { get; set; }

        //Campo de propiedad para edad
        private int _Edad;
        public int Edad
        {
            get
            {
                return this._Edad;
            }
            set
            {
                /*Necesitamos comprobar el valor que se ha 
                 * asignado a la propiedad edad
                 * 1) Error silencioso
                 * 2) Lanzar una excepcion
                 */
                if (value < 0)
                {
                    //this._Edad = 0;
                    throw new Exception("La edad no puede ser negativa " + value);
                }
                else
                {
                    this._Edad = value;
                }
            }
        }

        private TipoGenero _Genero;
        public TipoGenero Genero
        {
            get
            {
                return this._Genero;
            }
            set
            {
                //Debemos comprobar los valores de la enumeracion
                if (value != TipoGenero.Masculino && value != TipoGenero.Femenino)
                {
                    throw new Exception("Valor de Genero incorrecto");
                }
                else
                {
                    this._Genero = value;
                }
            }
        }
        public Paises Nacionalidad { get; set; }

        #endregion

        #region METODOS
        
        public string GetNombreCompleto()
        {
            return this.nombre + " " + this.apellidos;
        }

        //Sobrecarga
        public string GetNombreCompleto (bool orden)
        {
            if(orden == true)
            {
                return this.apellidos + " " + this.nombre;
            }
            else
            {
                return this.GetNombreCompleto();
            }
        }

        public void GetNombreCompleto(int num1, int num2)
        {

        }

        public int GetNombreCompleto(int num1)
        {
            return 0;
        }

        public string GetNombreCompleto(string a, string b)
        {
            return "Otro mas....";
        }

        public void MetodoParametrosOpcionales(int num1, int num2 = 444, int num3 = 0)
        {

        }

        #endregion
    }
}
