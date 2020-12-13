using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Connection con = new Connection(new ConnectionOpened());
            con.Open();
            con.Close();            
        }
    }

    public abstract class ConnectionState
    {
        public abstract void Open(Connection context);
        public abstract void Close(Connection context);
    }

    public class Connection
    {
        private ConnectionState _state;
        public Connection(ConnectionState state)
        {
            _state = state;
        }

        public ConnectionState State{
            get {
                return _state;
            }
            set {
                _state = value;
                Console.WriteLine($"State: {_state.GetType().Name }");
            }
        }

        public void Open(){
            _state.Open(this);
        }

        public void Close(){
            _state.Close(this);
        }
        
    }

    public class ConnectionClosed: ConnectionState
    {
        public override void Open(Connection context)
        {
            context.State = new ConnectionOpened();
        }

        public override void Close(Connection context)
        {
            context.State = new ConnectionClosed();
        }
    }
    public class ConnectionOpened: ConnectionState
    {
        public override void Open(Connection context)
        {
            context.State = new ConnectionOpened();
        }

        public override void Close(Connection context)
        {
            context.State = new ConnectionClosed();
        }
    }
}
