using System;
namespace Adapter
{
    public class Adaptee {
        public void SpecificRequest(){
            Console.WriteLine ("Método especifico de Adaptee foi chamado.");
        }
    }
    
}