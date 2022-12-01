/*
 * Created by SharpDevelop.
 * User: Usuario
 * Date: 31/8/2022
 * Time: 12:49 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Metodologías
{
    /// <summary>
    /// Description of Persona.
    /// </summary>
    public class Persona : Comparable
    {
        protected string nombre;
        protected int dni;
        public Persona(string n, int d)
        {
            nombre = n;
            dni = d;
        }
        public string getNombre
        {
            get { return nombre; }
        }
        public int getDni
        {
            get { return dni; }
        }

        public virtual bool sosIgual(Comparable c)
        {
            return dni == ((Persona)c).getDni;
        }
        public virtual bool sosMayor(Comparable c)
        {
            return dni > ((Persona)c).getDni;
        }
        public virtual bool sosMenor(Comparable c)
        {
            return dni < ((Persona)c).getDni;
        }
        public override string ToString()
        {
            return nombre + "\n" + dni.ToString() + "\n";
        }


    }
}
