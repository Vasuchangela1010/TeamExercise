using System;

namespace inheritance
{
    class Animal
    {
        public void Sleep()
        {
            Console.WriteLine("Zzzzzz");
        }

        public virtual void MakeNoise()
        {
            Console.WriteLine("DurrrDurrr");
        }
    }

    class Dog : Animal
    {
        public override void MakeNoise()
        {
            Console.WriteLine("WoofWoof");
        }
    }

    class Cat : Animal
    {
        public override void MakeNoise()
        {
            Console.WriteLine("Meaaooooow");
        }
    }

    class test
    {

        static void Main(string[] args)
        {
            Dog d1 = new Dog();
            Cat c1 = new Cat();
            d1.MakeNoise();
            c1.Sleep();

        }
    }
}
