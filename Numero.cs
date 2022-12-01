/*
 * Created by SharpDevelop.
 * User: Usuario
 * Date: 24/8/2022
 * Time: 10:17 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Metodologías
{
    /// <summary>
    /// Description of Numero.
    /// </summary>
    public class Numero : Comparable
    {

        private int valor;

        public Numero(int v)
        {
            valor = v;
        }

        public int getValor()
        {
            return valor;
        }
        public bool sosIgual(Comparable c)
        {
            return this.valor == ((Numero)c).getValor();
        }
        public bool sosMenor(Comparable c)
        {
            return this.valor < ((Numero)c).getValor();
        }
        public bool sosMayor(Comparable c)
        {
            return this.valor > ((Numero)c).getValor();
        }
        public override string ToString()
        {
            return valor.ToString();
        }

    }
}

