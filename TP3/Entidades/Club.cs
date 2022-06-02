using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Club
    {

        #region Atributos
        private List<Socio> listaSocios;
        private List<Empleado> listaEmpleados;
        private string nombre;
        #endregion

        #region Propiedades
        public List<Socio> ListaSocios
        {
            get { return listaSocios; }
        }
        public List<Empleado> ListaEmpleados
        {
            get { return listaEmpleados; }
        }
        #endregion

        #region Constructores
        public Club(string nombre)
        {
            this.nombre = nombre;
            this.listaSocios = new List<Socio>();
            this.listaEmpleados = new List<Empleado>();
        }
        public Club(string nombre, List<Socio> listaSocios)
        {
            this.nombre = nombre;
            this.listaSocios = listaSocios;
            this.listaEmpleados = new List<Empleado>();
        }
        public Club(string nombre, List<Empleado> listaEmpleados)
        {
            this.nombre = nombre;
            this.listaSocios = new List<Socio>();
            this.listaEmpleados = listaEmpleados;
        }
        public Club(string nombre, List<Socio> listaSocios, List<Empleado> listaEmpleados)
        {
            this.nombre = nombre;
            this.listaSocios = listaSocios;
            this.listaEmpleados = listaEmpleados;
        }

        #endregion

        #region Metodos
        public static bool operator ==(Club c, Socio s)
        {
            bool retorno = false;
            if (c is not null && s is not null)
            {
                foreach (Socio item in c.listaSocios)
                {
                    if (item == s)
                    {
                        retorno = true;
                    }
                }
            }
            return retorno;
        }
        public static bool operator !=(Club c, Socio s)
        {
            return !(c == s);
        }
        public static bool operator ==(Club c, Empleado e)
        {
            bool retorno = false;
            if (c is not null && e is not null)
            {
                foreach (Empleado item in c.listaEmpleados)
                {
                    if (item == e)
                    {
                        retorno = true;
                    }
                }
            }
            return retorno;
        }
        public static bool operator !=(Club c, Empleado e)
        {
            return !(c == e);
        }
        public static bool operator +(Club c, Socio s)
        {
            bool retorno = false;
            if (c is not null && s is not null)
            {
                if (c != s)
                {
                    c.listaSocios.Add(s);
                    retorno = true;
                }
            }
            return retorno;
        }
        //public static string operator -(Club c, Socio s)           // VER SI LO CAMBIO A RETURN BOOL
        //{
        //    string retorno = "Socio no encontrado";
        //    if (c is not null && s is not null)
        //    {
        //        if (c == s)
        //        {
        //            c.listaSocios.Remove(s);
        //            retorno = "Socio removido con éxito";
        //        }
        //    }
        //    return retorno;
        //}
        public static bool operator -(Club c, Socio s)           
        {
            bool retorno = false;
            if (c is not null && s is not null)
            {
                if (c == s)
                {
                    c.listaSocios.Remove(s);
                    retorno = true;
                }
            }
            return retorno;
        }
        public static bool operator +(Club c, Empleado e)
        {
            bool retorno = false;
            if (c is not null && e is not null)
            {
                if (c != e)
                {
                    c.listaEmpleados.Add(e);
                    retorno = true;
                }
            }
            return retorno;
        }
        //public static string operator -(Club c, Empleado e)           // VER SI LO CAMBIO A RETURN BOOL
        //{
        //    string retorno = "Empleado no encontrado";
        //    if (c is not null && e is not null)
        //    {
        //        if (c == e)
        //        {
        //            c.listaEmpleados.Remove(e);
        //            retorno = "Empleado removido con éxito";
        //        }
        //    }
        //    return retorno;
        //}
        public static bool operator -(Club c, Empleado e)
        {
            bool retorno = false;
            if (c is not null && e is not null)
            {
                if (c == e)
                {
                    c.listaEmpleados.Remove(e);
                    retorno = true;
                }
            }
            return retorno;
        }

        public string ImprimirListaSocios()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Socio socio in this.listaSocios)
            {
                sb.AppendLine($"{socio.ToString()}");
            }
            return sb.ToString();
        }
        public string ImprimirListaEmpleados()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Empleado empleado in this.listaEmpleados)
            {
                sb.AppendLine($"{empleado.ToString()}");
            }
            return sb.ToString();
        }
        #endregion
    }
}
