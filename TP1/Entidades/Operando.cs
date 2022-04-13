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

            binario = invertirString(binarioInvertido.ToString());

            return binario;

        }
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

                binario = invertirString(binarioInvertido.ToString());
            }
            else
            {
                binario = "Valor inválido";
            }

            return binario;

        }
        public static string invertirString(string stringAInvertir)
        {
            StringBuilder stringbuilder = new StringBuilder();

            for (int i = stringAInvertir.Length - 1; i >= 0; i--)
            {
                stringbuilder.Append(stringAInvertir[i]);
            }

            return stringbuilder.ToString();
        }
    }
}
