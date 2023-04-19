namespace Billetes
{
    public class Dolar
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        public static double CotzRespectoDolar { get => cotzRespectoDolar; }

        static Dolar() {
            cotzRespectoDolar = 1;
        }


    }
}