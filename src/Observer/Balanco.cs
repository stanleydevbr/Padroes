using System.Collections.Generic;
using System;
namespace Observer
{
    public class Balanco: Subject
    {
        public bool State {get;set;}

        public void Iniciar()
        {
            State = true;
            Console.WriteLine("Balanço iniciado...");
            // notifica os observadores
            Notify();
        }

        public void Finalizar()
        {
            State = false;
            Console.WriteLine("Balanço finalizado...");
            // notifica os observadores
            Notify();
        }
    }    
}