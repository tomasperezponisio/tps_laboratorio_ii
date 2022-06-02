using System;
using System.Text;
using System.Threading;
using System.Globalization;

namespace Entidades
{
    public abstract class Persona
    {
        #region Atributos        
        protected string nombre;
        protected string apellido;
        protected int dni;
        protected DateTime fechaNacimiento;
        protected int edad;                    // calcularla con la fecha de nacimiento     
        #endregion
                
        #region Propiedades
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }
        public int Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;               // Si dni es menor a 1 tirar EXCEPTION
            }
        }
        public DateTime FechaNacimiento
        {
            get
            {
                return this.fechaNacimiento;
            }
            set
            {
                this.fechaNacimiento = value;   // Si la fecha es la misma de hoy tirar EXCEPTION
            }
        }
        public int Edad
        {
            get
            {
                return this.edad;
            }
        }
        #endregion

        #region Constructor
        public Persona(string nombre, string apellido, int dni, DateTime fechaNacimiento)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
            this.FechaNacimiento = fechaNacimiento;
            this.edad = this.CalcularEdad();  // Revisar si esto tiene sentido            
        }
        #endregion

        #region Metodos
        private int CalcularEdad()
        {
            int edad = (int)((DateTime.Now - this.FechaNacimiento).TotalDays / 365.242199);
            return edad;
        }

        public static bool operator ==(Persona s1, Persona s2)
        {
            bool retorno = false;
            if (s1 is not null && s2 is not null)
            {
                if (s1.Dni == s2.Dni)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        public static bool operator !=(Persona s1, Persona s2)
        {
            return !(s1 == s2);
        }

        public override string ToString()                // LOS ATRIBUTOS HEREDADOS LOS LLAMO base.Nombre ? o desde this. ?
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("es-AR");
            StringBuilder sb = new StringBuilder();
            sb.Append($"Tipo: {this.GetType().Name} | ");
            sb.Append($"Nombre: {this.Nombre} | ");
            sb.Append($"Apellido: {this.Apellido} | ");
            sb.Append($"DNI: {this.Dni} | ");
            sb.Append($"Fecha Nac.: {this.FechaNacimiento.ToShortDateString()} | ");
            sb.Append($"Edad: {this.Edad}");           
            return sb.ToString();
        }

        #endregion

    }
}
