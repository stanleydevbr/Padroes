using System.Collections.Generic;
namespace Observer
{
    public abstract class Subject
    {
        private List<Observer> _observadores = new List<Observer>();

        public void Attach(Observer observer)  
        {
            // add um observador na lista
            _observadores.Add(observer);
        }
        public void Notify()
        {
            foreach (var o in _observadores)
            {
                o.Update();
            }
        }
    }
}