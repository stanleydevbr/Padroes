namespace ChainOfResponsability
{
    class Program
    {
        static void Main(string[] args)
        {
            var valForm = new Formulario();
            var valServer = new Server();
            var valBD = new BD();
            valForm.setSucessor(valServer);
            valServer.setSucessor(valBD);
            // passando requisição para cadeia de responsabilidade
            valForm.ValidateUser("User", "123");
        }
    }
}
