using System;

namespace AbstractFactory{

    public class OracleConnection: DBConnection
    {
        public override void Open(){
            Console.WriteLine("Método Oracle Connection foi executado com sucesso.");
        }
    }
}    