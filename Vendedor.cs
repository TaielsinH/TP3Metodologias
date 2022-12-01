using System;

namespace Metodologías
{
    public class Vendedor : Persona, IObservado
    {
        private int sueldoBasico;
        private double bonus;
        private int monto;
        private List<IObservador> observadores;

        public Vendedor(string n, int dni, int sueldoBasico) : base(n, dni)
        {
            this.sueldoBasico = sueldoBasico;
            bonus = 1;
            observadores = new List<IObservador>();
        }
        public void Venta(int monto)
        {
            Console.WriteLine(monto);
            this.monto = monto;
            notificar();
        }
        public int getSueldoBasico
        {
            get { return sueldoBasico; }
        }
        public int getMonto
        {
            get { return monto; }
        }
        public void aumentaBonus()
        {
            bonus += 0.1;
        }
        public double getBonus
        {
            get { return bonus; }
        }
        public bool sosIgual(Vendedor c)
        {
            return this.bonus == c.getBonus;
        }
        public bool sosMenor(Vendedor c)
        {
            return this.bonus < c.getBonus;
        }
        public bool sosMayor(Vendedor c)
        {
            return this.bonus > c.getBonus;
        }
        public override string ToString()
        {
            return "Nombre: " + this.nombre;
        }
        public void agregarObservador(IObservador o)
        {
            observadores.Add(o);
        }
        public void quitarObservador(IObservador o)
        {
            observadores.Remove(o);
        }
        public void notificar()
        {
            foreach(IObservador elem in observadores)
            {
                elem.actualizar(this);
            }
        }
    }
}

