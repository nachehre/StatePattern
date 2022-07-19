using System;

namespace StatePattern_02
{
    public class HappyPersonState : PersonStateBase
    {
        public override void SayHello()
        {
            Console.WriteLine("hiiiiiiiiiiiiiiiiiiiiiiii");
        }

        public override void SayGoodbye()
        {
            Console.WriteLine("byeeeeeeeeeeeeeeeeeeeeeeeeee");
        }
    }
}
