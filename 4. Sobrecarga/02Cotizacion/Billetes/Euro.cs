namespace Billetes
{
    public class Euro
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        public static double CotzRespectoDolar { get => cotzRespectoDolar; }

        static Euro() {
            cotzRespectoDolar = 0.909895;
        }


        public Euro(double cantidad) {

        }

        public Euro(double cantidad, double cotizacion) {

        }

    }
}