using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var con1 = ConexaoBaseDado.Instance();
            con1.stringConexao = "SQL Server";
            con1.Open();
            var con2 = ConexaoBaseDado.Instance();
            con2.Open();
            if (con1 == con2)
            Console.WriteLine("São a mesma instância");
        }
    }
}
