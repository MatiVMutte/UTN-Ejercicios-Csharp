using System.Text;

// Matias Mutte | 2B

namespace _03ConversorBinario
{
    internal class Program
    {
        static void Main(string[] args) {
            string binario = ConvertirDecimalABinario(50);

            Console.WriteLine(binario);

            int numero = ConvertirBinarioADecimal(110010 );

            Console.WriteLine(numero);
        }

        public static int ConvertirBinarioADecimal(int binarioEntero) {
            int numero = 0;
            int potencia = 0;

            string binario = binarioEntero.ToString();

            for(int i = binario.Length-1; i >= 0; i--) {
                if (binario[i] == '1') {
                    numero += (int)Math.Pow(2, potencia);
                }
                potencia++;
            }

            return numero;
        }

        public static string ConvertirDecimalABinario(int numeroEntero) {
            StringBuilder resto = new StringBuilder();
            StringBuilder binario = new StringBuilder();
            if(numeroEntero > 0) {
                do {
                    resto.Append(numeroEntero%2);
                    numeroEntero = numeroEntero / 2;
                } while(numeroEntero > 0);

                for (int i = resto.Length-1; i >= 0; i--) {
                    binario.Append(resto[i]);
                }
            }
            return binario.ToString();
        }
    }
}