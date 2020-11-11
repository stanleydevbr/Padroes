using System;
using System.Collections.Generic;

namespace Builder {
    public class Veiculo
    {
        private string _tipo;
        private Dictionary<string,string> _parts = new Dictionary<string,string>();
        public Veiculo(string tipo)
        {
            _tipo = tipo;
        }
        
        public string this[string key]{
            get {return _parts[key];}
            set {_parts[key] = value;}
        }

        public void Mostrar(){
            Console.WriteLine("***********************************************************");
            Console.WriteLine($"Tipo: {_tipo}");
            Console.WriteLine($"Motor: {_parts["motor"]}");
            Console.WriteLine($"Pneus: {_parts["pneus"]}");
            Console.WriteLine($"Portas: {_parts["portas"]}");
            Console.WriteLine("***********************************************************");
        }
    }

}