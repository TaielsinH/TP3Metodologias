
using System;

namespace Metodologías
{
    /// <summary>
    /// Description of ColeccionMultiple.
    /// </summary>
    public class ColeccionMultiple : Coleccionable
    {
        Pila p;
        Cola c;
        public ColeccionMultiple(Pila p, Cola c)
        {
            this.p = p;
            this.c = c;
        }
        public int cuantos()
        {
            int pCantidad = p.cuantos();
            int cCantidad = c.cuantos();
            int resultado = pCantidad + cCantidad;
            return resultado;
        }
        public Comparable minimo()
        {
            Comparable minPila = p.minimo();
            Comparable minCola = c.minimo();
            Comparable min = minPila;
            if ((minCola).sosMenor(minPila))
                min = minCola;
            return min;
        }
        public Comparable maximo()
        {
            Comparable maxPila = p.maximo();
            Comparable maxCola = c.maximo();
            Comparable max = maxPila;

            if ((maxCola).sosMayor(maxPila))
                max = maxCola;
            return max;
        }
        public void agregar(Comparable c) { }

        public bool contiene(Comparable comparacion)
        {
            bool resultado = p.contiene(comparacion);
            if (resultado)
                return resultado;

            resultado = c.contiene(comparacion);
            return resultado;
        }
    }
}

