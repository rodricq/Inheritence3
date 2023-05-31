using System;

namespace Inheritence3
{
    class Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("I eat food");
        } 
        //derived class of Animal
        class Dog : Animal
        {
            //overriding method from Animal
            public override void eat()
            {
                Console.WriteLine("I eat Dog food");
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                //object of derived class
                Dog labrador = new Dog();
                labrador.eat();

                Console.ReadKey();
            }
        }
    }
}
