namespace AbstractFactory{
    public abstract class DBFactory
    {
        public abstract DBConnection CreateConnection();
        public abstract DBCommand CreateCommand(); 
    }
}    