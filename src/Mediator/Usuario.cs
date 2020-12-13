using System;

namespace Mediator
{
    public class Usuario : Colleague
    {
        public Usuario(Mediator mediator)
        :base(mediator)
        {

        }
        public void Send(string message){
            _mediator.Send(message, this);
        }
        public void Notify(string message)
        {
            Console.WriteLine($"Usuário recebeu a mensagem: {message}");
        }
    }

}
