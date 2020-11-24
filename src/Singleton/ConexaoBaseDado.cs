using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
    public class ConexaoBaseDado
    {
        private static ConexaoBaseDado _instance;
        // esconde o construtor 
        protected ConexaoBaseDado(){}
        public static ConexaoBaseDado Instance()
        {
            // garante que apenas uma instância seja criada.
            if (_instance == null)
                _instance = new ConexaoBaseDado();
            return _instance;
        }
        public string stringConexao { get; set; }
        public void Open()
        {
            Console.WriteLine($"Conexao com banco {stringConexao}");
        }
    }

}