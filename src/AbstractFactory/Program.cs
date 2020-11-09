using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new OracleFactory();
            var con = db.CreateConnection();
            con.Open();
            var cmd = db.CreateCommand();
            cmd.Execute();

        }
    }
}
