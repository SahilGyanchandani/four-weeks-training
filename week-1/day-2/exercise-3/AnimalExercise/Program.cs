namespace Animal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[2];

            Dog dog = new Dog("Tommy", 7);

            Cat cat = new Cat("Kitty", 5);

            animals[0] = dog;
            animals[1] = cat;

            // calling make sound method
            dog.MakeSound();
            cat.MakeSound();


            // calling move method
            dog.Move();
            cat.Move();
        }
    }

    abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public abstract void MakeSound();
    }

    interface IMovable
    {
        void Move();
    }

    class Dog : Animal, IMovable
    {

        public Dog(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
        override
        public void MakeSound()
        {
            Console.WriteLine("Dog goes woof woof woof...");
        }

        public void Move()
        {
            Console.WriteLine("This dog is moving right now...");
        }
    }

    class Cat : Animal, IMovable
    {

        public Cat(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
        override
        public void MakeSound()
        {
            Console.WriteLine("Cat goes meow meow...");
        }

        public void Move()
        {
            Console.WriteLine("This cat is moving right now...");
        }
    }
}