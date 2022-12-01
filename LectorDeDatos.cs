using System;

namespace Metodologías
{
    public class LectorDeDatos
    {
        public int NumeroPorTeclado()
        {
            int numero = 0;
            Console.Write("Ingrese Numero: ");
            numero = int.Parse(Console.ReadLine());
            return numero;
        }
        public string StringPorTeclado()
        {
            string cadena = " ";
            Console.Write("Ingrese cadena de caracteres: ");
            cadena = Console.ReadLine();
            return cadena;
        }
    }
}

