namespace _01Prestamo
{
    internal class Program
    {
        static void Main(string[] args) {
            int opcion;
            double saldo;

            Cuenta miCuenta = new Cuenta("Matias Mutte", 100);

            while(true) {
                Console.WriteLine($"Hola {miCuenta.Titular}");
                Console.WriteLine("1. Mostrar datos de cuenta\n" +
                                   "2. Ingresar saldo a la cuenta\n" +
                                   "3. Retirar saldo de la cuenta");
                Console.WriteLine($" > Ingresa una opcion >> ");
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcion) {
                    case 1:
                        Console.WriteLine(miCuenta);
                        break;
                    case 2:
                        Console.WriteLine(" > Ingrese el saldo a guardar >> ");
                        saldo = double.Parse(Console.ReadLine());
                        miCuenta.IngresarSaldo(saldo);
                        break;
                    case 3:
                        Console.WriteLine(" > Ingrese el saldo a retirar >> ");
                        saldo = double.Parse(Console.ReadLine());
                        miCuenta.RetirarSaldo(saldo);
                        break;
                    default:
                        Console.WriteLine("No corresponde al menu.");
                        break;
                }
                Console.WriteLine(" >> Toca cualquier tecla para continuar <<");
                Console.ReadKey();
                Console.Clear();
            }



        }
    }
}