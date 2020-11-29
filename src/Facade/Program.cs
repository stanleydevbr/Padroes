namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var email = new Email();
            email.Enviar("Olá, você esta encaminhando um e-mail ao mundo.");
        }
    }    
}
