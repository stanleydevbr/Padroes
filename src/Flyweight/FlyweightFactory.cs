using System.Collections;

namespace Flyweight
{
    public class FlyweightFactory
    {
        private Hashtable _flyweights = new Hashtable();

        //constructor
        public FlyweightFactory()
        {
            _flyweights.Add("A", new ConcreteFlyweight());
            _flyweights.Add("B", new ConcreteFlyweight());
            _flyweights.Add("C", new ConcreteFlyweight());
        }

        public Flyweight getFlyweight(string key)
        {
            return (Flyweight)_flyweights[key];
        }
    }

}
