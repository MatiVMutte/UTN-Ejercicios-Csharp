namespace Billetes
{
    public class Peso
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        public static double CotzRespectoDolar { get => cotzRespectoDolar; }

        static Peso() {
            cotzRespectoDolar = 208.90;
        }


    }
}