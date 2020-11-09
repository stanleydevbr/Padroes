namespace AbstractFactory{
    public class SQLFactory : DBFactory
    {
        public override DBConnection CreateConnection(){
            return new SQLConnection();
        }
        
        public override DBCommand CreateCommand(){
            return new SQLCommand();
        }
        
    }
}