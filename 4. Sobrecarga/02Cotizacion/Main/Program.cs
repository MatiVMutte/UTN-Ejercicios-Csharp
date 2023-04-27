using Billetes;
using System.Text;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args) {

            string[] monedas = {"DOLAR", "PESO", "EURO"};
            Dolar dolar;
            Peso peso;
            Euro euro;
            string? monedaTengo;
            string? monedaConvertir;
            double cantidad;
            StringBuilder mensaje = new StringBuilder();
            ConsoleKeyInfo tecla;


            do {
                monedaTengo = pedirMoneda("¿Que moneda queres convertir? (dolar, peso, euro) >> ", monedas);

                monedaConvertir = pedirMoneda("¿A que moneda queres convertir? (dolar, peso, euro) >> ", monedas);

                cantidad = pedirMonto("Ingresa el monto a convertir >> ");

                switch (monedaTengo) {
                    case "DOLAR":

                        dolar = cantidad;
                        mensaje.Append($" > {(monedaTengo == "DOLAR" ? "U$S" : "")} {dolar.Cantidad} ==> {(monedaConvertir == "PESO" ? "$" : "€")} ");

                        if (monedaConvertir == "PESO") {
                            peso = (Peso)dolar;
                            mensaje.Append($"{peso.Cantidad}");
                        } else if (monedaConvertir == "EURO") {
                            euro = (Euro)dolar;
                            mensaje.Append($"{euro.Cantidad}");
                        }

                        break;
                    case "PESO":

                        peso = cantidad;
                        mensaje.Append($" > {(monedaTengo == "PESO" ? "$" : "")} {peso.Cantidad} ==> {(monedaConvertir == "EURO" ? "€" : "U$S")}");

                        if (monedaConvertir == "EURO") {
                            euro = (Euro)peso;
                            mensaje.Append($"{euro.Cantidad}");
                        } else if (monedaConvertir == "DOLAR") {
                            dolar = (Dolar)peso;
                            mensaje.Append($"{dolar.Cantidad}");
                        }

                        break;
                    case "EURO":

                        euro = cantidad;
                        mensaje.Append($" > {(monedaTengo == "EURO" ? "€" : "")} {euro.Cantidad} ==> {(monedaConvertir == "PESO" ? "$" : "U$S")}");

                        if (monedaConvertir == "PESO") {
                            peso = (Peso)euro;
                            mensaje.Append($"{peso.Cantidad}");
                        } else if (monedaConvertir == "DOLAR") {
                            dolar = (Dolar)euro;
                            mensaje.Append($"{dolar.Cantidad}");
                        }
                        break;
                }

                Console.WriteLine(mensaje);

                Console.WriteLine("<><><> ¿Queres seguir? - Ingrese S/N <><><>");
                tecla = Console.ReadKey();

                mensaje.Clear();
                Console.Clear();
            } while (tecla.Key == ConsoleKey.S);
        }

        public static string pedirMensaje(string mensaje) {
            string? cadena;
            Console.Write(mensaje);
            cadena = Console.ReadLine();
            return cadena;
        }

        public static string pedirMoneda(string mensaje, string[] monedas) {
            string moneda;
            do {
                moneda = pedirMensaje(mensaje);
                if (moneda != null) {
                    moneda = moneda.ToUpper();
                }
            } while (!(monedas.Contains(moneda)) || moneda == null);
            return moneda;
        }

        public static double pedirMonto(string mensaje) {
            double cantidad;
            bool conversionDouble;
            do {
                Console.Write(mensaje);
                conversionDouble = double.TryParse(Console.ReadLine(), out cantidad);
            } while (!conversionDouble || cantidad < 1);
            return cantidad;
        }
    }
}