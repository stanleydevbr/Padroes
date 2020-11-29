using System;

namespace ChainOfResponsability
{
    public class BD : BaseValidate
    {
        public override bool ValidateUser(string name, string password)
        {
            bool ret = name == password;
            Console.WriteLine("Validação feita no Banco de Dados:" + ret);
            // encadeia chamada
            if (_sucessor != null)
                _sucessor.ValidateUser(name, password);
            return ret;
        }
    }
}
