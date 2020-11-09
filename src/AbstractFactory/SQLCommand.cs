
using System;

namespace AbstractFactory{

    public class SQLCommand: DBCommand
    {
        public override void Execute(){
            Console.WriteLine("Metodo SQL Command executado com sucesso.");
        }
    }
}