namespace Flyweight
{
    class Program
    {
        //Client
        static void Main(string[] args)
        {
            // externo
            int ext = 10;

            FlyweightFactory fabrica = new FlyweightFactory();
            Flyweight f1 = fabrica.getFlyweight("A");
            f1.Operation(ext++);
            Flyweight f2 = fabrica.getFlyweight("B");
            f2.Operation(ext++);
            Flyweight f3 = fabrica.getFlyweight("C");
            f3.Operation(ext++);
            Flyweight f4 = fabrica.getFlyweight("A");
            f4.Operation(ext++);
            Flyweight f5 = new UnsharedConcreteFlyweight();
            f5.Operation(ext++);
        }
    }

}
