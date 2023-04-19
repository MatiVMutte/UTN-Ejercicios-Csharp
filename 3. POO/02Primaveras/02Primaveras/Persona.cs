using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Primaveras
{
    internal class Persona
    {

        private String nombre;
        private DateTime fechaDeNacimiento;
        private int dni;

        public Persona(String nombre, DateTime fechaDeNacimiento, int dni) {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }



        private int CalcularEdad() {
            return DateTime.Now.Year - fechaDeNacimiento.Year;
        }



        public String Nombre {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            } 
        }

        public DateTime Fecha {
            get
            {
                return fechaDeNacimiento;
            }
            set
            {
                fechaDeNacimiento = value;
            }
        }

    }
}
