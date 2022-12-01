using System;

namespace Metodologías
{
    public interface IObservador
    {
        public void actualizar(IObservado o);
    }
    public interface IObservado
    {
        public void agregarObservador(IObservador o);
        public void quitarObservador(IObservador o);
        public void notificar();
    }
}

