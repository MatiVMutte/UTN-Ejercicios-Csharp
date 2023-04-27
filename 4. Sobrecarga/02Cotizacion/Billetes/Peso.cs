namespace Billetes
{
    public class Peso
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        public static double CotzRespectoDolar { get => cotzRespectoDolar; }
        public double Cantidad { get => cantidad; }

        static Peso() {
            cotzRespectoDolar = 218;
        }

        public Peso(double cantidad) {
            this.cantidad = cantidad;
        }

        public Peso(double cantidad, double cotizacion) :this(cantidad) {
            cotzRespectoDolar = cotizacion;
        }

        #region Conversiones -------------------------------------

        public static explicit operator Peso(Dolar dolar) {
            return new Peso(dolar.Cantidad * cotzRespectoDolar);
        }

        public static explicit operator Peso(Euro euro) {
            return (Peso)(Dolar)euro;
        }

        public static implicit operator Peso(double peso) {
            return new Peso(peso);
        }

        #endregion

        #region Comparaciones -------------------------------------

        // Peso con Dolar
        public static bool operator !=(Peso peso, Dolar dolar) {
            return dolar != peso;
        }

        public static bool operator ==(Peso peso, Dolar dolar) {
            return dolar == peso;
        }

        // Peso con Euro
        public static bool operator !=(Peso peso, Euro euro) {
            return euro != peso;
        }

        public static bool operator ==(Peso peso, Euro euro) {
            return euro == peso;
        }

        // Peso con Peso
        public static bool operator !=(Peso peso, Peso peso2) {
            return !(peso == peso2);
        }

        public static bool operator ==(Peso peso, Peso peso2) {
            return peso.cantidad == peso2.cantidad;
        }

        #endregion

        #region Operaciones -------------------------------------

        // Dolar con Euro
        public static Dolar operator +(Peso peso, Euro euro) {
            return euro + peso;
        }

        public static Dolar operator -(Peso peso, Euro euro) {
            Peso peso2 = (Peso)euro;
            return new Dolar(peso.cantidad - peso2.Cantidad);
        }

        // Dolar con Peso
        public static Dolar operator +(Peso peso, Dolar dolar) {
            return dolar + peso;
        }

        public static Dolar operator -(Peso peso, Dolar dolar) {
            Peso peso2 = (Peso)dolar;
            return new Dolar(peso.cantidad - peso2.Cantidad);
        }

        #endregion

    }
}