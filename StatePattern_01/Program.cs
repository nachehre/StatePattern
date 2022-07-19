using System;

namespace StatePattern_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.SayHello();
            person.SayGoodbye();

            Console.Read();
        }
    }

    public enum PersonStatus
    {
        Happy = 1,
        Sad = 2,
        Angry = 3
    }

    public class Person
    {
        public Person(string name)
        {
            Status = PersonStatus.Happy;
            Name = name;
        }

        public string Name { get; set; }
        public PersonStatus Status { get; set; }
        
        public void SayHello()
        {
            if (Status == PersonStatus.Happy)
            {
                Console.WriteLine("hiiiiiiiiiiiiiiiiiiiiiiii");
            }

            if(Status == PersonStatus.Sad)
            {
                Console.WriteLine("hom");
            }

            if(Status == PersonStatus.Angry)
            {
                throw new InvalidOperationException();
            }
        }

        public void SayGoodbye()
        {
            if (Status == PersonStatus.Happy)
            {
                Console.WriteLine("byeeeeeeeeeeeeeeeeeeeeeeeeee");
            }

            if (Status == PersonStatus.Sad)
            {
                Console.WriteLine("bye");
            }

            if (Status == PersonStatus.Angry)
            {
                throw new InvalidOperationException();
            }
        }

        public void Angry()
        {
            Status = PersonStatus.Angry;
        }

        public void Sad()
        {
            Status = PersonStatus.Sad;
        }
    }
}
