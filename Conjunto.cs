using System;
using System.Collections;

namespace Metodologías
{
    public class Conjunto : Coleccionable, Iterable
    {
        private List<Comparable> elementos;

        public Conjunto()
        {
            elementos = new List<Comparable>();
        }
        public Iterador crearIterador()
        {
            return new IteradorConjuntos(elementos);
        }
        public void agregar(Comparable c)
        {
            if (!pertenece(c))
                elementos.Add(c);
        }

        private bool pertenece(Comparable c)
        {
            bool esta = false;
            for (int i = 0; i < elementos.Count; i++)
            {
                if (elementos[i] == c)
                    esta = true;
                break;
            }
            return esta;
        }
        public int cuantos()
        {
            return elementos.Count;
        }
        public Comparable minimo()
        {
            Comparable min = elementos[0];
            for (int i = 0; i < elementos.Count - 1; i++)
            {
                if (elementos[i].sosMenor(min))
                    min = elementos[i];
            }
            return min;
        }
        public Comparable maximo()
        {
            Comparable max = elementos[0];
            for (int i = 0; i < elementos.Count - 1; i++)
            {
                if (elementos[i].sosMayor(max))
                    max = elementos[i];
            }
            return max;
        }
        public bool contiene(Comparable c)
        {
            bool encontrado = false;
            for (int i = 0; i < elementos.Count - 1; i++)
            {
                if (c.sosIgual(elementos[i]))
                {
                    encontrado = true;
                    return encontrado;
                }

            }
            return encontrado;
        }

    }
}