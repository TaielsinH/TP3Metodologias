using System;

namespace Metodologías
{
    public interface Strategy
    {
        bool esIgual(Comparable a, Comparable b);
        bool esMenor(Comparable a, Comparable b);
        bool esMayor(Comparable a, Comparable b);
    }
    public class porDNI : Strategy
    {
        public bool esIgual(Comparable a, Comparable b)
        {
            return ((Alumno)a).getDni == ((Alumno)b).getDni;
        }

        public bool esMenor(Comparable a, Comparable b)
        {
            return ((Alumno)a).getDni < ((Alumno)b).getDni;
        }

        public bool esMayor(Comparable a, Comparable b)
        {
            return ((Alumno)a).getDni > ((Alumno)b).getDni;
        }
    }
    public class porNombre : Strategy
    {
        public bool esIgual(Comparable a, Comparable b)
        {
            return ((Alumno)a).getNombre == ((Alumno)b).getNombre;
        }
        public bool esMenor(Comparable a, Comparable b)
        { return ((Alumno)a).getNombre.Length < ((Alumno)b).getNombre.Length; 
        }
        public bool esMayor(Comparable a, Comparable b)
        {
            return ((Alumno)a).getNombre.Length > ((Alumno)b).getNombre.Length; 
        }
    }
    public class porLegajo : Strategy
    {
        public bool esIgual(Comparable a, Comparable b)
        {
            return ((Alumno)a).getLegajo == ((Alumno)b).getLegajo;
        }
        public bool esMenor(Comparable a, Comparable b)
        {
            return ((Alumno)a).getLegajo < ((Alumno)b).getLegajo;
        }

        public bool esMayor(Comparable a, Comparable b)
        {
            return ((Alumno)a).getLegajo > ((Alumno)b).getLegajo;
        }
    }
    public class porPromedio : Strategy
    {
        public bool esIgual(Comparable a, Comparable b)
        {
            return ((Alumno)a).getPromedio == ((Alumno)b).getPromedio;
        }
        public bool esMenor(Comparable a, Comparable b)
        {
            return ((Alumno)a).getPromedio < ((Alumno)b).getPromedio;
        }
        public bool esMayor(Comparable a, Comparable b)
        {
            return ((Alumno)a).getPromedio > ((Alumno)b).getPromedio;
        }
    }

}