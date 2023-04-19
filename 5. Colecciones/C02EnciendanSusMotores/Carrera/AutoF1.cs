namespace Carrera
{
    public class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string? escuderia;
        private short numero;
        private short vueltasRestantes;

        public AutoF1(string? escuderia, short numero) {
            enCompetencia = false;
            cantidadCombustible = 0;
            vueltasRestantes = 0;
            this.escuderia = escuderia;
            this.numero = numero;
        }
        public static bool operator !=(AutoF1 a1, AutoF1 a2) {
            return !(a1 == a2);
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2) {
            bool autosIguales = false;

            if(a1.numero == a2.numero && a1.escuderia == a2.escuderia) {
                autosIguales = true;
            }

            return autosIguales;
        }


        #region Propiedades
        public short CantidadCombustible { get => cantidadCombustible; set => cantidadCombustible = value; }
        public bool EnCompetencia { get => enCompetencia; set => enCompetencia = value; }
        public short VueltasRestantes { get => vueltasRestantes; set => vueltasRestantes = value; }
        #endregion

        public override string ToString() {
            string compitiendo = "No esta en competencia";
            if(enCompetencia) {
                compitiendo = "Esta compitiendo";
            }
            return $"Auto: {numero} y  Escuderia: {escuderia} - Cantidad de combustible: {cantidadCombustible}\nCompetencia: {compitiendo}\nVueltas restantes: {vueltasRestantes}\n"; // Editar
        }

    }
}