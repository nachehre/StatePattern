using System;

namespace StatePattern_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Morning +++++++++++++++++++++++++++++++
            var nasim = new Person("Nasim");
            nasim.SayHello();

            //Afternoon ++++++++++++++++++++++++++++++++
            nasim.Sad();
            nasim.SayHello();

            //Night +++++++++++++++++++++++++++++++++++++
            nasim.Angry();
            nasim.SayGoodbye();

            Console.ReadLine();
        }
    }
}
