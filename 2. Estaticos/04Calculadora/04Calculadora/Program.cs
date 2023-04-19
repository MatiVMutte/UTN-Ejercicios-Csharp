namespace _04Calculadora
{
    internal class Program
    {
        static void Main(string[] args) {
            double num1;
            double num2;
            char operacion;
            double resultado;
            char opcion;
            bool continuar = true;

            while (continuar) {
                Console.WriteLine("Ingrese el primer número:");
                num1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el segundo número:");
                num2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la operación a realizar (+, -, *, /):");
                operacion = char.Parse(Console.ReadLine());

                resultado = Calculadora.Calcular(num1, num2, operacion);
                Console.WriteLine("El resultado de la operación es: " + resultado);

                Console.WriteLine("¿Desea continuar? (s/n)");
                opcion = char.Parse(Console.ReadLine().ToLower());

                continuar = opcion == 's';
            }
        }
    }
}