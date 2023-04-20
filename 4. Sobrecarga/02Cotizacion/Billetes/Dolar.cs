namespace Billetes
{
    public class Dolar
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        public static double CotzRespectoDolar { get => cotzRespectoDolar; }
        public double Cantidad { get => cantidad; }

        static Dolar() {
            cotzRespectoDolar = 1;
        }

        public Dolar(double cantidad) {
            this.cantidad = cantidad;
        }

        #region Conversiones -------------------------------

        public static explicit operator Dolar(Euro euro) {
            return new Dolar(euro.Cantidad / Euro.CotzRespectoDolar);
        }

        public static explicit operator Dolar(Peso peso) {
            return new Dolar(peso.Cantidad / Peso.CotzRespectoDolar);
        }

        public static implicit operator Dolar(double dolar) {
            return new Dolar(dolar);
        }

        #endregion

        #region Comparaciones -------------------------------

        // Dolar con Euro
        public static bool operator !=(Dolar dolar, Euro euro) {
            return !(dolar == euro);
        }

        public static bool operator ==(Dolar dolar, Euro euro) {
            Dolar dolar2 = (Dolar)euro;

            return dolar.cantidad == dolar2.cantidad;
        }

        // Dolar con Peso
        public static bool operator !=(Dolar dolar, Peso peso) {
            return !(dolar == peso);
        }

        public static bool operator ==(Dolar dolar, Peso peso) {
            Dolar dolar2 = (Dolar)peso;

            return dolar.cantidad == dolar2.cantidad;
        }

        // Dolar con Dolar
        public static bool operator !=(Dolar dolar, Dolar dolar2) {
            return !(dolar == dolar2);
        }

        public static bool operator ==(Dolar dolar, Dolar dolar2) {
            return dolar.cantidad == dolar2.cantidad;
        }

        #endregion

        #region Operaciones -------------------------------

        // Dolar con Euro
        public static Dolar operator +(Dolar dolar, Euro euro) {
            Dolar dolar2 = (Dolar)euro;
            return new Dolar(dolar.cantidad + dolar2.Cantidad);
        }

        public static Dolar operator -(Dolar dolar, Euro euro) {
            Dolar dolar2 = (Dolar)euro;
            return new Dolar(dolar.cantidad - dolar2.Cantidad);
        }

        // Dolar con Peso
        public static Dolar operator +(Dolar dolar, Peso peso) {
            Dolar dolar2 = (Dolar)peso;
            return new Dolar(dolar.cantidad + dolar2.Cantidad);
        }

        public static Dolar operator -(Dolar dolar, Peso peso) {
            Dolar dolar2 = (Dolar)peso;
            return new Dolar(dolar.cantidad - dolar2.Cantidad);
        }

        #endregion
    }
}