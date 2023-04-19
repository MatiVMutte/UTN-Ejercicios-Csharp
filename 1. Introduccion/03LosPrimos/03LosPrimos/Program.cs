using System.Text;

namespace _03LosPrimos
{
    internal class Program
    {
        static void Main(string[] args) {
            int numero;
            string linea;

            String numeroCadena = "16452";
            int acumulador = 0;

            foreach(char num in numeroCadena) {
                numero = int.Parse(num.ToString());
                acumulador += numero;
            }

            Console.WriteLine(acumulador);

            while (true) {
                Console.WriteLine("Ingrese un numero(\"salir\" para terminar): ");
                linea = Console.ReadLine();

                if (linea != null && linea.Length != 0) {

                    if (linea == "salir") {
                        break;
                    }

                    // Valido que sea un numero entero simple

                    if(!esEnteroPositivo(linea)) {
                        continue;
                    }

                    // Fin validacion numerico

                    // Numeros Primos

                    numero = int.Parse(linea);

                    Console.WriteLine("\n\nNumeros primos hasta el numero");

                    if(numero > 1) {
                        for(int i = 2; i <= numero; i++) {
                            if(esPrimo(i)) {
                                Console.WriteLine(i);
                            }
                        }
                    }


                }

                if(!seguir()) {
                    break;
                }
            }

        }

        static bool esEnteroPositivo(string linea) {
            bool esEntero = true;

            for (int i = 0; i < linea.Length; i++) {
                if (linea[i] < 47 || linea[i] > 58) {
                    esEntero = false;
                }
            }
            return esEntero;
        }

        static bool esPrimo(int numero) {
            bool primo = true;

            for (int i = 2; i < numero; i++) {
                if ((numero % i) == 0) {
                    // No es primo
                    primo = false;
                }
            }
            return primo;
        }

        static bool seguir() {
            string? linea;
            bool sigue = false;

            Console.WriteLine("¿Desea seguir?");
            linea = Console.ReadLine();
            if(linea != null) {
                linea = linea.ToLower();
                if (linea == "si") {
                    sigue = true;
                }
            }

            return sigue;
        }

    }
}