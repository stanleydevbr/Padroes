using System;

namespace ChainOfResponsability
{
    // ConcreteHandler
    public class Formulario : BaseValidate
    {
        public override bool ValidateUser(string name, string password)
        {
            var ret = false;
            if (name != null)
                if (password != null)
                    ret = true;
            Console.WriteLine("Validação feita em formulário:" + ret);
            // encadeia chamada
            if (_sucessor != null)
                _sucessor.ValidateUser(name, password);
            return ret;
        }
    }
}
