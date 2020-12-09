using System;

namespace Interator
{
    // Iterator
    public abstract class Iterator
    {
        public abstract Object First();
        public abstract Object Next();
        public abstract bool IsDone();
        public abstract Object CurrentItem();
    }
}