namespace StatePattern_02
{
    public class Person
    {
        public Person(string name)
        {
            State = new HappyPersonState();
            Name = name;
        }

        public string Name { get; set; }
        public PersonStateBase State { get; set; }

        public void SayHello()
        {
            State.SayHello();
        }

        public void SayGoodbye()
        {
            State.SayGoodbye();
        }

        public void Angry()
        {
            State = new AngryPersonState();
        }

        public void Sad()
        {
            State = new SadPersonState();
        }
    }
}
