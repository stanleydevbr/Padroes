namespace AbstractFactory{
    public class OracleFactory: DBFactory
    {
        public override DBConnection CreateConnection(){
            return new OracleConnection();
        }
        public override DBCommand CreateCommand(){
            return new OracleCommand();
        }
    }
}