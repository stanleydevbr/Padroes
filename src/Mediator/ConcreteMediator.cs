namespace Mediator
{
    public class ConcreteMediator : Mediator
    {
        private Suporte _suporte;
        private Usuario _usuario;
        public Suporte Suporte {
            set {_suporte = value;}
        }

        public Usuario Usuario {
            set {_usuario = value;}
        }

        public override void Send(string message, Colleague colleague)
        {
            if (colleague == _usuario)
                _suporte.Notify(message);
            else
                _usuario.Notify(message);
        }
    }

}
