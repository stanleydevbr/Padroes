using System;

namespace ChainOfResponsability
{
    // ConcreteHandler
    public class Server : BaseValidate
    {
        public override bool ValidateUser(string name, string password)
        {
            bool ret = name == password;
            Console.WriteLine("Validação feita em server:" + ret);
            // encadeia chamada
            if (_sucessor != null)
                _sucessor.ValidateUser(name, password);
            return ret;
        }
    }
}
