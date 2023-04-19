using Carrera;

namespace C02EnciendanSusMotores
{
    internal class Program
    {
        static void Main(string[] args) {
            bool seAgrego;

            Competencia primeraCompetencia = new Competencia(2, 3);

            AutoF1 unAuto = new AutoF1("Matute", 999);
            AutoF1 otroAuto = new AutoF1("Mutte", 777);
            AutoF1 otroAuto1 = new AutoF1("Mutte", 777);


            #region SE AGREGAN 2 AUTOS
                Console.ForegroundColor = ConsoleColor.Green; /** 
             ****************** Se Agregan 2 autos ***********************
             * */

            Console.WriteLine("Se agregan dos autos a la competicion");
            seAgrego = primeraCompetencia + unAuto; // Se AGREGA un auto
            seAgrego = primeraCompetencia + otroAuto; // Se AGREGA otro auto

            /**
             ************************* FIN ********************************
             * */ Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(primeraCompetencia); // >>>> Mostramos los competidores <<<<
            #endregion


            #region SE ELIMINA UN AUTO
                Console.ForegroundColor = ConsoleColor.Red; /** 
             ****************** Se Elimina 1 auto ***********************
             * */
            Console.WriteLine("Se elimina el Matute de la competicion");
            seAgrego = primeraCompetencia - unAuto; // Se ELIMINA un auto
            /**
             ************************* FIN ********************************
             * */Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(primeraCompetencia); // >>>> Mostramos los competidores <<<<
            #endregion


            #region SE INTENTA AGREGAR OTRO AUTO QUE YA ESTA
            Console.ForegroundColor = ConsoleColor.Yellow; /** 
             ****************** Se Intenta agregar un auto que ya existe ***********************
             * */

            Console.WriteLine("Se intenta agregar un auto que ya existe en la competicion");
            seAgrego = primeraCompetencia + otroAuto1; // Se INTENTA AGREGAR un auto QUE YA ESTA EN LA COMPETENCIA
            if (!seAgrego) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No se puede agregar ese auto, ya esta en la competicion");
            }

            /**
             ************************* FIN ********************************
             * */Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(primeraCompetencia); // >>>> Mostramos los competidores <<<<

            #endregion

        }
    }
}