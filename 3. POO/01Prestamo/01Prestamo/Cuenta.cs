using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Prestamo
{
    internal class Cuenta
    {

        #region "Atributos"
        // ----- Start -----
        private String titular;
        private double saldo;
        private static int contador;
        // ----- End -----
        #endregion


       
        #region "Constructor"
        // ----- Start -----
        static Cuenta() { // Se ejecuta una sola vez. La primera interaccion
            contador = 0;
        }

        public Cuenta(String titular, double saldo) {
            contador++;
            this.titular = titular;
            this.saldo = saldo;
        }
        // ----- End -----
        #endregion



        #region "Metodos"
        // ----- Start -----
        public override string ToString() {
            return $"{this.titular}  - ${this.saldo}\n";
        }
        

        public void IngresarSaldo(double saldo) {
            if(saldo > 0) {
                this.saldo += saldo;
            }
        }

        public void RetirarSaldo(double saldo) {
            this.saldo -= saldo;
        }

        // ----- End -----
        #endregion



        #region "Setter y Getter"
        // ----- Start -----
        public String Titular {
            get
            {
                return titular;
            }
            set
            {
                titular = value;
            }
        }

        public double Saldo {
            get
            {
                return saldo;
            }
            set
            {
                saldo = value;
            }
        }
        // ----- End -----
        #endregion
    }
}
