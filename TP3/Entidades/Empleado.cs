using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Empleado : Persona
    {
        #region Anidados
        public enum EArea { Administrativo, Mantenimiento, Seguridad }
        public enum ETurno { Mañana, Tarde } 
        #endregion

        #region Atributos
        private EArea area;
        private ETurno turno;
        #endregion

        #region Propiedades
        public EArea Area
        {
            get { return area; }
            set { area = value; }
        }
        public ETurno Turno
        {
            get { return turno; }
            set { turno = value; }
        }
        #endregion

        #region Constructores
        public Empleado(string nombre, string apellido, int dni, DateTime fechaNacimiento, EArea area, ETurno turno)
            : base(nombre, apellido, dni, fechaNacimiento)
        {
            this.area = area;
            this.turno = turno;
        }
        #endregion

        #region Metodos
        public override string ToString()                // LOS ATRIBUTOS HEREDADOS LOS LLAMO base.Nombre ? o desde this. ?
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.ToString()}  | ");
            sb.AppendLine($"Area: {this.Area}  | ");
            sb.AppendLine($"Turno: {this.Turno}");
            return sb.ToString();
        }
        #endregion
    }
}
