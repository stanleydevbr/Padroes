using System;

namespace Flyweight
{
    public class ConcreteFlyweight : Flyweight
    {
        public override void Operation(int ext)
        {
            Console.WriteLine("Concrete Flyweight: " + ext);
        }
    }

}
