using System;

namespace StatePattern_02
{
    public class SadPersonState : PersonStateBase
    {
        public override void SayHello()
        {
            Console.WriteLine("hom");
        }

        public override void SayGoodbye()
        {
            Console.WriteLine("bye");
        }
    }
}
