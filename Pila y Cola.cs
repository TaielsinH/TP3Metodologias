/*
 * Created by SharpDevelop.
 * User: Usuario
 * Date: 30/8/2022
 * Time: 7:45 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
namespace Metodologías
{
    /// <summary>
    /// Description of Pila_y_Cola.
    /// </summary>
    public class Pila : Iterable, Coleccionable
    {
        private List<Comparable> elementos;
        public Iterador crearIterador()
        {
            return new IteradorPilas(elementos);
        }
        public Pila()
        {
            elementos = new List<Comparable>();
        }
        public void Push(Comparable c)
        {
            elementos.Add(c);
        }
        public Comparable Pop()
        {
            Comparable retorno = elementos[elementos.Count - 1];
            elementos.RemoveAt(elementos.Count - 1);
            return retorno;
        }
        public void imprimirElementos()
        {
            Console.Write("[");
            foreach (Comparable el in elementos)
            {
                int ele = ((Numero)el).getValor();
                Console.Write(ele + ",");
            }
            Console.Write("]");
            Console.WriteLine("");
        }
        public void agregar(Comparable c)
        {
            Push(c);
        }
        public int cuantos()
        {
            int cantidad = 0;
            for (int i = 0; i < elementos.Count; i++)
                cantidad++;
            return cantidad;
        }
        public Comparable minimo()
        {
            Comparable min = elementos[0];
            for (int i = 0; i < elementos.Count - 1; i++)
            {
                if ((elementos[i]).sosMenor(min))
                    min = elementos[i];
            }
            return min;
        }
        public Comparable maximo()
        {
            Comparable max = elementos[0];
            for (int i = 0; i < elementos.Count - 1; i++)
            {
                if ((elementos[i]).sosMayor(max))
                    max = elementos[i];
            }
            return max;
        }
        public bool contiene(Comparable c)
        {
            for (int i = 0; i < elementos.Count - 1; i++)
            {
                if ((elementos[i]).sosIgual(c))
                    return true;
            }
            return false;
        }
 
    }
    public class Cola : Iterable, Coleccionable
    {
        private List<Comparable> elementos;
        public Iterador crearIterador()
        {
            return new IteradorColas(elementos);
        }
        public Cola()
        {
            elementos = new List<Comparable>();
        }
       
 
        public void Push(Comparable c)
        {
            elementos.Add(c);
        }
        public Comparable Pull()
        {
            Comparable retorno = elementos[0];
            elementos.RemoveAt(0);
            return retorno;
        }
        public void imprimirElementos()
        {
            Console.Write("[");
            foreach (Comparable el in elementos)
            {
                int ele = ((Numero)el).getValor();
                Console.Write(ele + ",");
            }
            Console.Write("]");
            Console.WriteLine("");
        }
        public int cuantos()
        {
            int cantidad = 0;
            for (int i = 0; i < elementos.Count; i++)
                cantidad++;
            return cantidad;
        }
        public Comparable minimo()
        {
            Comparable min = elementos[0];
            for (int i = 0; i < elementos.Count - 1; i++)
            {
                if ((elementos[i]).sosMenor(min))
                    min = elementos[i];
            }
            return min;
        }
        public Comparable maximo()
        {
            Comparable max = elementos[0];
            for (int i = 0; i < elementos.Count - 1; i++)
            {
                if ((elementos[i]).sosMayor(max))
                    max = elementos[i];
            }
            return max;
        }
        public bool contiene(Comparable c)
        {
            for (int i = 0; i < elementos.Count - 1; i++)
            {
                if ((elementos[i]).sosIgual(c))
                    return true;
            }
            return false;
        }
        public void agregar(Comparable c)
        {
            Push(c);
        }
    }
}
