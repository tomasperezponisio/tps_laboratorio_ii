using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        // Atributos
        private double numero;

        // Constructores
        public Operando(double numero)
        {
            this.numero = numero;
        }
        public Operando() : this(0)
        { }
        public Operando(string strNumero)
        {
            this.numero = ValidarOperando(strNumero);
        }

        // Propiedades
        public string Numero
        {
            set { this.numero = ValidarOperando(value); }
        }

        // Metodos
        /// <summary>
        /// Valida el operando que recibe, si no es un numero devuelve 0
        /// </summary>
        /// <param name="strNumero"> El operando a validar, es del tipo string</param>
        /// <returns> Devuelve en double el operando que recibe</returns>
        private double ValidarOperando(string strNumero)
        {
            double numero;
            bool resultado = double.TryParse(strNumero, out numero);
            if (!resultado)
            {
                numero = 0;
            }
            return numero;
        }
        public static double operator +(Operando n1, Operando n2)  // operador suma
        {
            return n1.numero + n2.numero;
        }
        public static double operator -(Operando n1, Operando n2)  // operador resta
        {
            return n1.numero - n2.numero;
        }
        public static double operator *(Operando n1, Operando n2)  // operador multiplicacion
        {
            return n1.numero * n2.numero;
        }
        public static double operator /(Operando n1, Operando n2)  // operador division
        {
            double resultado;
            if (n2.numero != 0)
            {
                resultado = n1.numero / n2.numero;
            }
            else
            {
                resultado = Double.MinValue;
            }
            return resultado;
        }
        /// <summary>
        /// Checkea que el string que recibe son 0 y 1
        /// </summary>
        /// <param name="binario">Recibe un numero en string</param>
        /// <returns>devuelve true si el string recibido esta compuesto por 0 y 1, false en caso contrario</returns>
        private bool EsBinario(string binario)
        {
            bool resultado = true;
            foreach (char letra in binario)
            {
                if (letra != '1' && letra != '0')
                {
                    resultado = false;
                }
            }
            return resultado;
        }
        /// <summary>
        /// De ser posible convierte a Decimal el numero recibido, todo de tipo string, si no se puede devuelve un mensaje de error
        /// </summary>
        /// <param name="binario"> Recibe un numero a convertir, es de tipo string</param>
        /// <returns> Devuelve el numero en decimal o un mensaje de error si no se pudo convertir</returns>
        public string BinarioDecimal(string binario)
        {
            string resultado;
            int numeroAEvaluar;
            int sumador;
            int numeroDecimal = 0;
            if (EsBinario(binario))
            {
                for (int i = binario.Length - 1; i >= 0; i--)
                {
                    numeroAEvaluar = int.Parse(binario[i].ToString());
                    if (numeroAEvaluar == 0)
                    {
                        sumador = 0;
                    }
                    else
                    {
                        sumador = (int)Math.Pow(2, binario.Length - 1 - i);
                    }
                    numeroDecimal += sumador;
                }
                resultado = numeroDecimal.ToString();
            }
            else
            {
                resultado = "Valor inválido";
            }

            return resultado;
        }
        /// <summary>
        /// De ser posible convierte a binario el numero recibido (en double),
        /// </summary>
        /// <param name="numero"> Recibe un numero a convertir, es de tipo double </param>
        /// <returns> Devuelve el numero en decimal  </returns>
        public string DecimalBinario(double numero)
        {            
            StringBuilder binarioInvertido = new StringBuilder();
            string binario;
            int dividendo = (int)Math.Floor(Math.Abs(numero));
            int resto;

            while (dividendo >= 2)
            {
                resto = dividendo % 2;
                binarioInvertido.Append(resto.ToString());
                dividendo = dividendo / 2;
            }
            binarioInvertido.Append(dividendo.ToString());

            // invierto el string
            char[] arrayDeCaracteres = binarioInvertido.ToString().ToCharArray();
            Array.Reverse(arrayDeCaracteres);
            binario = new string(arrayDeCaracteres);

            return binario;

        }
        /// <summary>
        /// De ser posible convierte a binario el numero recibido (en string), si no se puede devuelve un mensaje de error
        /// </summary>
        /// <param name="numero"> Recibe un numero a convertir, es de tipo string </param>
        /// <returns> Devuelve el numero en binario (string) o un mensaje de error si no se pudo convertir </returns>
        public string DecimalBinario(string numero)
        {
            bool resultado = double.TryParse(numero, out double numeroDouble);
            string binario;
            if (resultado)
            {
                StringBuilder binarioInvertido = new StringBuilder();
                double dividendo = Math.Floor(Math.Abs(numeroDouble));
                double resto;

                while (dividendo >= 2)
                {
                    resto = dividendo % 2;
                    binarioInvertido.Append(resto.ToString());
                    dividendo = dividendo / 2;
                }
                binarioInvertido.Append(dividendo.ToString());

                // invierto el string
                char[] arrayDeCaracteres = binarioInvertido.ToString().ToCharArray();
                Array.Reverse( arrayDeCaracteres );
                binario = new string(arrayDeCaracteres);

            }
            else
            {
                binario = "Valor inválido";
            }

            return binario;

        }
    }
}
