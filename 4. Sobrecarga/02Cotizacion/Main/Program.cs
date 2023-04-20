using Billetes;
using System.Text;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args) {

            Dolar dolar;
            Peso peso;
            Euro euro;
            string[] monedas = {"DOLAR", "PESO", "EURO"};
            string? monedaTengo;
            string? monedaConvertir;
            double cantidad;
            bool conversionDouble;
            StringBuilder mensaje = new StringBuilder();
            ConsoleKeyInfo tecla;


            do {
                do {
                    Console.Write("¿Que moneda queres convertir? (dolar, peso, euro) >> ");
                    monedaTengo = Console.ReadLine();
                    if (monedaTengo != null) {
                        monedaTengo = monedaTengo.ToUpper();
                    }
                } while (!(monedas.Contains(monedaTengo)) || monedaTengo == null);

                do {
                    Console.Write("¿A que moneda queres convertir? (dolar, peso, euro) >> ");
                    monedaConvertir = Console.ReadLine();
                    if (monedaConvertir != null) {
                        monedaConvertir = monedaConvertir.ToUpper();
                    }
                } while (!(monedas.Contains(monedaConvertir)) || monedaConvertir == null);

                do {
                    Console.Write("Ingresa el monto a convertir >> ");
                    conversionDouble = double.TryParse(Console.ReadLine(), out cantidad);
                } while (!conversionDouble || cantidad < 1);


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
    }
}