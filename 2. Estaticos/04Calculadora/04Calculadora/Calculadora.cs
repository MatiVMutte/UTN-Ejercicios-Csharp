using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Calculadora
{
    internal class Calculadora
    {

        public static double Calcular(double num1, double num2, char operacion) {
            double resultado = 0;
            switch (operacion) {
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
                    if (Validar(num2)) {
                        resultado = num1 / num2;
                    } else {
                        Console.WriteLine("Error: división por cero");
                    }
                    break;
                default:
                    Console.WriteLine("Operación inválida");
                    break;
            }
            return resultado;
        }

        private static bool Validar(double num2) {
            return num2 != 0;
        }

    }
}
