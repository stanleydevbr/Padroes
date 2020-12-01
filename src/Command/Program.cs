namespace Command
{
    class Program
    {
        //Client
        static void Main(string[] args)
        {
            // configura Receiver
            Server server = new Server();
            // cria comando configurando o receiver
            Command cmd = new ServerCommand(server);
            // configura o Invoker
            Formulario form = new Formulario();
            // configura e executar o comando...
            form.setCommand(cmd);
            form.ClickValidate();
        }
    }
}

