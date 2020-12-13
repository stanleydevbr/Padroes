using System;

namespace Mediator
{
    public class Suporte : Colleague
    {
        public Suporte(Mediator mediator)
        :base(mediator)
        {}

        public void Send(string message)
        {
            _mediator.Send(message, this);
        }
        public void Notify(string message)
        {
            Console.WriteLine($"Suporte recebeu a mensagem: {message}");
        }
    }

}
