
using System;

namespace Metodologías
{
    /// <summary>
    /// Description of Alumno.
    /// </summary>
    public class Alumno : Persona
    {
        private int legajo;
        private float promedio;
        private static string opcion = "promedio";
        public Alumno(string n, int d, int legajo, float promedio) : base(n, d)
        {
            this.legajo = legajo;
            this.promedio = promedio;
        }
        public static string Opcion
        {
            get { return opcion; }
            set { opcion = value; }
        }

        public int getLegajo { get { return legajo; } }

        public float getPromedio { get { return promedio; } }

        public override bool sosIgual(Comparable c)
        {
            if (opcion == "legajo")
                return legajo == ((Alumno)c).getLegajo;
            else
                return promedio == ((Alumno)c).getPromedio;
        }
        public override bool sosMenor(Comparable c)
        {
            if (opcion == "legajo")
                return legajo < ((Alumno)c).getLegajo;
            else
                return promedio < ((Alumno)c).getPromedio;
        }
        public override bool sosMayor(Comparable c)
        {
            if (opcion == "legajo")
                return legajo > ((Alumno)c).getLegajo;
            else
                return promedio > ((Alumno)c).getLegajo;
        }
        public override string ToString()
        {
            return nombre + " dni: " + dni.ToString() + "  legajo: " + legajo.ToString() + "  promedio: " + promedio.ToString();
        }

    }
}

