using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Socio : Persona
    {
        #region Anidados
        public enum EActividad { Basquet, Futbol, Natacion, Voley } 
        public enum ECategoria { Joven, Adulto, Mayor }            
        //private enum EEstadoCuenta { Debe, Pago }
        #endregion

        #region Atributos
        private EActividad actividad ;
        private ECategoria categoria;                              //  ESTO SE DEBE CARGAR AUTOAMTICO SEGUN LA EDAD
                                                                   //private EEstadoCuenta estadoCuenta;
        #endregion

        #region Propiedades
        public EActividad Actividad
        {
            get { return actividad; }
            set { actividad = value; }
        }
        public ECategoria Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        } 
        #endregion

        #region Constructores        
        public Socio(string nombre, string apellido, int dni, DateTime fechaNacimiento, EActividad eActividad, ECategoria categoria)
            : base(nombre, apellido, dni, fechaNacimiento)
        {
            this.actividad = eActividad;
            this.categoria = categoria;
        }
        public Socio():this(String.Empty, String.Empty, -1, DateTime.Now, EActividad.Natacion, ECategoria.Joven)
        {

        }
        #endregion

        #region Metodos
        public override string ToString()                // LOS ATRIBUTOS HEREDADOS LOS LLAMO base.Nombre ? o desde this. ?
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.ToString()}  | ");            
            sb.AppendLine($"Actividad: {this.Actividad}  | ");
            sb.AppendLine($"Categoria: {this.Categoria}");
            return sb.ToString();
        } 
        #endregion
    }
}
