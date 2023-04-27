namespace Billetes
{
    public class Euro
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        public static double CotzRespectoDolar { get => cotzRespectoDolar; }
        public double Cantidad { get => cantidad; }

        static Euro() {
            cotzRespectoDolar = 0.91;
        }

        public Euro(double cantidad) {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion):this(cantidad) {
            cotzRespectoDolar = cotizacion;
        }

        #region Conversiones -----------------------------------------------

        public static explicit operator Euro(Dolar dolar) {
            return new Euro(dolar.Cantidad * cotzRespectoDolar);
        }

        public static explicit operator Euro(Peso peso) {
            return (Euro)(Dolar)peso;
        }

        public static implicit operator Euro(double euro) {
            return new Euro(euro);
        }

        #endregion

        #region Comparaciones -----------------------------------------------

        // Euro con Dolar
        public static bool operator !=(Euro euro, Dolar dolar) {
            return dolar != euro;
        }

        public static bool operator ==(Euro euro, Dolar dolar) {
            return dolar == euro;
        }

        // Euro con Peso
        public static bool operator !=(Euro euro, Peso peso) {
            return !(euro == peso);
        }

        public static bool operator ==(Euro euro, Peso peso) {
            return euro == (Euro)peso;
        }

        // Euro con Euro
        public static bool operator !=(Euro euro, Euro euro2) {
            return !(euro == euro2);
        }

        public static bool operator ==(Euro euro, Euro euro2) {
            return euro.cantidad == euro2.cantidad;
        }

        #endregion

        #region Operaciones -----------------------------------------------

        // Dolar con Euro
        public static Dolar operator +(Euro euro, Dolar dolar) {
            return dolar + euro;
        }

        public static Dolar operator -(Euro euro, Dolar dolar) {
            Euro euro2 = (Euro)dolar;
            return euro.Cantidad - euro2.Cantidad;
        }

        // Dolar con Peso
        public static Dolar operator +(Euro euro, Peso peso) {
            Euro euro2 = (Euro)peso;
            return new Dolar(euro.cantidad + euro2.Cantidad);
        }

        public static Dolar operator -(Euro euro, Peso peso) {
            Euro euro2 = (Euro)peso;
            return new Dolar(euro.cantidad - euro2.Cantidad);
        }

        #endregion

    }
}