using System;

namespace Flyweight
{
    public class UnsharedConcreteFlyweight : Flyweight
    {
        public override void Operation(int ext)
        {
            Console.WriteLine("UnsharedConcreteFlyweight: " + ext);
        }
    }

}
