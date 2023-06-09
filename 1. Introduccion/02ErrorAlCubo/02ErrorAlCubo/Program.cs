﻿namespace _02ErrorAlCubo
{

    /*
     Ingresar un número y mostrar el cuadrado y el cubo del mismo. 
     Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
    */

    internal class Program
    {
        static void Main(string[] args) {
            int numero;
            string? linea;

            do {
                Console.WriteLine("Ingrese un numero mayor a 0: ");
            } while (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0);

            Console.WriteLine("El numero " + numero + " al cuadrado es: " + Math.Pow(numero, 2));
            Console.WriteLine("El numero " + numero + " al cubo es: " + Math.Pow(numero, 3));
        }
    }
}