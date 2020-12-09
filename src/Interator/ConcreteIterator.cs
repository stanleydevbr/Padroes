using System;

namespace Interator
{
    public class ConcreteIterator : Iterator
    {
        private Equipe _aggregate;
        private int current = 0;
        public ConcreteIterator(Equipe aggregate)
        {
            _aggregate = aggregate;
        }
        public override object First()
        {
            return _aggregate[0];
        }
        public override object Next()
        {
            Object ret = null;
            if (current < _aggregate.Count - 1)
                ret = _aggregate[++current];
            return ret;
        }
        public override bool IsDone()
        {
            return current >= _aggregate.Count ? true : false;
        }
        public override object CurrentItem()
        {
            return _aggregate[current];
        }
    }
}