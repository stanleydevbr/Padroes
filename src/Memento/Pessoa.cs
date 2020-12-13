using System;

namespace Memento
{
    public class Pessoa
    {
        public string State { get; set; }
        public Memento CreateMemento(){
            return new Memento(State);
        }
        
        public void SetMemento(Memento memento){
            Console.WriteLine("Restaurando o estado...");
            State = memento.State;
        }
    }
}
