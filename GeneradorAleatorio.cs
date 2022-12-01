using System;
using System.Linq;

namespace Metodologías
{
    public class GeneradorDeDatosAleatorios
    {
        public int numeroAleatorio(int max)
        {
            Random random = new Random();
            int num = random.Next(0,max);
            return num;
        }
        public string stringAleatorio(int cant)
        {
            var caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            var caracteresArray = new char[cant];
            var random = new Random();

            for (int i = 0; i < caracteresArray.Length; i++)
            {
                caracteresArray[i] = caracteres[random.Next(caracteres.Length)];
            }
            var resulNombre = new String(caracteresArray);
            return resulNombre;
        }
    }
}

