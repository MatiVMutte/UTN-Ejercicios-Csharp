using System.Diagnostics.CodeAnalysis;

namespace _01MaximoMinimoPromedio
{
    /*
     Ingresar 5 números por consola, guardándolos en una variable escalar.
     Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.
     */
    internal class Program
    {
        static void Main(string[] args) {
            // Ejer 01 - Matute
            int numero;
            int suma = 0;
            int promedio;
            int maximo = 0;
            int minimo = 0;
            string? cadena;

            for(int i = 0; i < 5; i++) {
                Console.WriteLine("Ingrese el numero: ");
                cadena = Console.ReadLine();

                while(int.TryParse(cadena, out numero) == false) {
                    Console.WriteLine("No es un numero. Vuelva a ingresar: ");
                    cadena = Console.ReadLine();
                }

                if(i == 0) {
                    maximo = numero;
                    minimo = numero;
                }

                if(numero > maximo) {
                    maximo = numero;
                }
                
                if(numero < minimo) {
                    minimo = numero;
                }

                suma +=numero;
            }

            promedio = suma / 5;

            Console.WriteLine("El numero mas grande ingresado es: " + maximo);
            Console.WriteLine("El numero mas chico ingresado es: " + minimo);
            Console.WriteLine("El promedio es: " + promedio);

        }
    }
}