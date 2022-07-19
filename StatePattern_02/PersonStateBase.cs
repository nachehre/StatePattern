using System;

namespace StatePattern_02
{
    public abstract class PersonStateBase
    {
        public virtual void SayHello()
        {
            throw new InvalidOperationException();
        }

        public virtual void SayGoodbye()
        {
            throw new InvalidOperationException();
        }
    }
}
