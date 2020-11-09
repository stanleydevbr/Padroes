
using System;

namespace AbstractFactory{

    public class SQLConnection: DBConnection
    {
        public override void Open(){
            Console.WriteLine("Método SQL Connection foi executado com sucesso.");
        }
    }
}
