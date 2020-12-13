namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteMediator mediator = new ConcreteMediator();
            Suporte suporte = new Suporte(mediator);
            Usuario usuario = new Usuario(mediator);
            mediator.Suporte = suporte;
            mediator.Usuario = usuario;
            usuario.Send("Meu Sistema não esta carregando.");
            suporte.Send("E preciso reiniciar o sistema.");
        }
    }

}
