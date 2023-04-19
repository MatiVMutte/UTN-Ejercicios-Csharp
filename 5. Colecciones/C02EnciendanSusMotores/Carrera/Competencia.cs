using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;
        


        private Competencia() {
            competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadCompetidores, short cantidadVueltas): this() {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
        }

        public static bool operator -(Competencia c, AutoF1 a) {
            bool seAgrego = false;

            // Falta validar...
            if(c == a) {
                c.competidores.Remove(a);
                seAgrego = true;
            }

            return seAgrego;
        }

        public static bool operator +(Competencia c, AutoF1 a) {
            Random rnd = new Random();
            bool seAgrego = false;

            if (c != a && c.competidores.Count <= c.cantidadCompetidores) {
                c.competidores.Add(a);  
                a.EnCompetencia = true;
                a.VueltasRestantes = c.cantidadVueltas;
                a.CantidadCombustible = (short)rnd.Next(15, 101);
                seAgrego = true;
            }

            return seAgrego;
        }

        public static bool operator ==(Competencia c, AutoF1 a) {
            bool seAgrego = false;

            foreach (AutoF1 competidor in c.competidores) {
                if(competidor == a) {
                    seAgrego = true;
                }
            }

            return seAgrego;
        }

        public static bool operator !=(Competencia c, AutoF1 a) {
            return !(c == a);
        }



        public override string ToString() {
            int numeroCompetidor = 0;
            string competidorString;
            StringBuilder competidores = new StringBuilder();

            foreach (AutoF1 competidor in this.competidores) {
                numeroCompetidor++;
                competidorString = $"{numeroCompetidor}: {competidor}";
                competidores.AppendLine(competidorString);
            }

            return competidores.ToString(); // Editar
        }
    }
}
