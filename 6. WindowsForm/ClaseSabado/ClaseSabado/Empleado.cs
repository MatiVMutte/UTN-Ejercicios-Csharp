using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseSabado
{
    public class Empleado
    {
        private String _nombre;
        private float _sueldo;
        String path_imagen; // Guardaria el PATH de la imagen

        public Empleado(string nombre, float sueldo, String path) {
            _nombre = nombre;
            _sueldo = sueldo;
            path_imagen = path;
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public float Sueldo { get => _sueldo; set => _sueldo = value; }
        public string Path_imagen { get => path_imagen; set => path_imagen = value; }

        public override String ToString() {
            return _nombre + " - " + _sueldo;
        }
    }
}
