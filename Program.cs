
using System;
using System.Linq;

namespace Metodologías
{
    class Program
    {
        public static void Main(string[] args)
        {
            Pila pila = new Pila();
            llenar(pila, 3);
            Gerente ger = new Gerente();
            Iterador iterador = pila.crearIterador();
            while(!iterador.fin())
            {
                ((Vendedor)iterador.actual()).agregarObservador(ger);
                iterador.siguiente();
            }
            jornadaDeVentas(pila);
            ger.Cerrar();
            Console.ReadKey(true);

        }
        public static void jornadaDeVentas(Iterable vendedores)
        {
            Iterador iterador = vendedores.crearIterador();
            for (int i = 0; i<20; i++)
            {
                iterador.primero();
                while(!iterador.fin())
                {
                    GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
                    int monto = generador.numeroAleatorio(7000);
                    ((Vendedor)iterador.actual()).Venta(monto);
                    iterador.siguiente();
                }
            }
        }
        public static void llenar(Coleccionable col, int opcion)
        {
            for (int i = 0; i < 20; i++)
            {
                Comparable elemento = FabricaDeComparables.crearAleatorio(opcion);
                col.agregar(elemento);
            }
        }
        public static void Informar(Coleccionable col, int opcion)
        {
            Console.WriteLine(col.cuantos());
            Console.WriteLine(col.minimo());
            Console.WriteLine(col.maximo());
            Comparable com = FabricaDeComparables.crearPorTeclado(opcion);
            if (col.contiene(com))
            {
                Console.WriteLine("El elemento leído está en la colección");
            }
            else
            { Console.WriteLine("El elemento leído no está en la colección"); }
        }
        public static void ImprimirElementos(Iterable col)
        {
            Iterador iterador = col.crearIterador();
            while(!iterador.fin())
            {
                Console.WriteLine(iterador.actual().ToString());
                Console.WriteLine("===");
                iterador.siguiente();
            }
        }
        public static string nombreAzar()
        {
            var caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            var caracteresArray = new char[8];
            var random = new Random();

            for (int i = 0; i < caracteresArray.Length; i++)
            {
                caracteresArray[i] = caracteres[random.Next(caracteres.Length)];
            }
            var resulNombre = new String(caracteresArray);
            return resulNombre;
        }
        public static int dniAzar()
        {
            var numeros = "1234567890";
            var numerosArray = new char[8];
            var random = new Random();

            for (int i = 0; i < numerosArray.Length; i++)
                numerosArray[i] = numeros[random.Next(numeros.Length)];
            var resulDni = new String(numerosArray);
            int resultado = int.Parse(resulDni);
            return resultado;
        }

  /*      public static void llenarPersonas(Coleccionable col)
        {
            for (int i = 0; i < 20; i++)
            {
                string n = nombreAzar();
                int dni = dniAzar();
                Comparable persona = new Persona(n, dni);
                col.agregar(persona);
            }
        }

        public static void llenarAlumnos(Coleccionable col)
        {
            for (int i = 0; i < 10; i++)
            {
                Strategy comparador = new porNombre(); //ejercicio 2 del tp2
                Comparable alumno = new Alumno(nombreAzar(), dniAzar(), legajoAzar(), promedioAzar());
                Comparable alumno2;
                col.agregar(alumno);
                do
                {
                    alumno2 = new Alumno(nombreAzar(), dniAzar(), legajoAzar(), promedioAzar());
                } while (comparador.esIgual(alumno, alumno2)); //utilización de strategy para evitar que salgan dos nombres iguales
                col.agregar(alumno2);
            }
        }*/

        public static float promedioAzar()
        {
            Random rnd = new Random();
            float promedio = rnd.Next(1, 10);
            return promedio;
        }

        public static int legajoAzar()
        {
            var numeros = "1234567890";
            var numerosArray = new char[6];
            var random = new Random();

            for (int i = 0; i < numerosArray.Length; i++)
                numerosArray[i] = numeros[random.Next(numeros.Length)];
            var resulDni = new String(numerosArray);
            int resultado = int.Parse(resulDni);
            return resultado;
        }



 /*       public static void llenar(Coleccionable c)
        {
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
                c.agregar(new Numero(rnd.Next(1, 20)));
        }*/
        public static void informar(Coleccionable c)
        {
            int cantidad = c.cuantos();
            Console.WriteLine("La lista tiene {0} elementos", cantidad);
            Console.Write("Ingrese 'legajo' si quiere comparar por legajos o 'promedio' si por eso quiere comparar: ");
            Alumno.Opcion = Console.ReadLine();
            Comparable min = c.minimo();
            if (Alumno.Opcion == "legajo")
                Console.WriteLine("El mínimo de la lista es: " + ((Alumno)min).getLegajo);
            else
                Console.WriteLine("El mínimo de la lista es: " + ((Alumno)min).getPromedio);

            Comparable max = c.maximo();
            if (Alumno.Opcion == "legajo")
                Console.WriteLine("El maximo numero de la lista es: " + ((Alumno)max).getLegajo);
            else
                Console.WriteLine("El maximo numero de la lista es: " + ((Alumno)max).getPromedio);

            Console.Write("Ingrese el nombre del alumno: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese el dni: ");
            int dni = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el legajo del alumno: ");
            int legajo = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el promedio: ");
            float promedio = float.Parse(Console.ReadLine());

            Comparable num = new Alumno(nombre, dni, legajo, promedio);
            if (c.contiene(num))
                Console.WriteLine("La lista contiene ese numero");
            else
            {
                Console.WriteLine("La lista no contiene ese numero");
            }
        }
    }
}