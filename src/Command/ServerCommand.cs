using System;

namespace Command
{
    // ConcreteCommand
    public class ServerCommand : Command
    {
        private Server _server;
        public ServerCommand(Server server)
        {
            this._server = server;
        }
        public override void Execute()
        {
            Console.WriteLine("ServerCommand - ConcreteCommand: Validando usuário");
            _server.ValidateUser();
        }
    }
}

