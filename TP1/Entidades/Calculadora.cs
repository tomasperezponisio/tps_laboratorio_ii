using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        // Metodos
        /// <summary>
        /// Valida que el operador que recibe sea + - * ó / y si no es niguno de esos, devuelve +
        /// </summary>
        /// <param name="operador">Recibe el operador como char</param>
        /// <returns>Devuelve el operador valido como char</returns>
        private static char ValidarOperador(char operador)
        {
            if (operador != '-' && operador != '*' && operador != '/')
            {
                operador = '+';
            }
            return operador;
        }
        /// <summary>
        /// Recibe los operandos y el operador y hace la operacion con los operadores sobrecargados
        /// </summary>
        /// <param name="num1">El primero operando, es del tipo Operando</param>
        /// <param name="num2">El segundo operando, es del tipo Operando</param>
        /// <param name="operador">El operador, es del tipo char</param>
        /// <returns>Devuelve el resultado de la operacion, es del tipo double</returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double resultado = 0;
            switch (ValidarOperador(operador))
            {
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                case '/':
                    resultado = num1 / num2;
                    break;
            }

            return resultado;
        }
    }
}
