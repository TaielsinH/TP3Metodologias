using System;

namespace Metodologías
{
    public class Gerente : IObservador
    {
        Conjunto mejores;
        public Gerente()
        {
            mejores = new Conjunto();
        }
        public void Cerrar()
        {
            Console.WriteLine("Nombre de los mejores vendedores: ");
            Iterador iterador = mejores.crearIterador();
            while (!iterador.fin())
            {
                Console.WriteLine(iterador.actual().ToString());
                Console.WriteLine("===");
                iterador.siguiente();
            }
        }
        public void Venta(int monto, Vendedor vend)
        {
            if (monto > 5000)
            {
                mejores.agregar(vend);
                vend.aumentaBonus();
            }
        } 
        public void actualizar(IObservado o)
        {
            Venta(((Vendedor)o).getMonto , (Vendedor)o);
        }
    }
}

