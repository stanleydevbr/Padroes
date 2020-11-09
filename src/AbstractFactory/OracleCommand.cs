
using System;

namespace AbstractFactory{
    public class OracleCommand: DBCommand
    {   
        public override void Execute(){
            Console.WriteLine("Método Oracle Command executado com sucesso.");
        }
    }
}
