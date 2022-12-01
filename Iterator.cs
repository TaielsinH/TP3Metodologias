using System;

namespace Metodologías
{
    public interface Iterador
    {
        void primero();
        void siguiente();
        bool fin();
        Comparable actual();
    }
    public interface Iterable
    {
        Iterador crearIterador();
    }
    public class IteradorDiccionarios : Iterador
    {
        private int puntero;
        private List<ClaveValor> lista;
        public IteradorDiccionarios(List<ClaveValor> dicc)
        {
            lista = dicc;
            puntero = 0;
        }
        public void primero()
        {
            puntero = 0;
        }
        public void siguiente()
        {
            puntero++;
        }
        public bool fin()
        {
            return puntero == lista.Count() - 1;
        }
        public Comparable actual()
        {
            return lista[puntero].getValor();
        }
    }
    public class IteradorConjuntos : Iterador
    {
        private int puntero;
        private List<Comparable> lista;
        public IteradorConjuntos(List<Comparable> con)
        {
            lista = con;
            puntero = 0;
        }
        public void primero()
        {
            puntero = 0;
        }
        public void siguiente()
        {
            puntero++;
        }
        public bool fin()
        {
            return puntero == lista.Count() - 1;
        }
        public Comparable actual()
        {
            return lista[puntero];
        }

    }
    public class IteradorPilas : Iterador
    {
        private int puntero;
        private List<Comparable> lista;

        public IteradorPilas(List<Comparable> pila)
        {
            lista = pila;
            puntero = lista.Count()-1;
        }
        public Comparable actual()
        {
            return lista[puntero];
        }
        public void primero()
        {
            puntero = lista.Count() - 1;
        }
        public void siguiente()
        {
            puntero--;
        }
        public bool fin()
        {
            return puntero == 0;
        }
    }
    public class IteradorColas : Iterador
    {
        private int puntero;
        private List<Comparable> lista;
        public IteradorColas(List<Comparable> cola)
        {
            lista = cola;
            puntero = 0;
        }
        public void primero()
        {
            puntero = 0;
        }
        public void siguiente()
        {
            puntero++;
        }
        public bool fin()
        {
            return puntero == lista.Count()-1;
        }
        public Comparable actual()
        {
            return lista[puntero];
        }
    }
}