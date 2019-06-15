using System;

namespace ClassInheldens
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] zoo = new Animal[10];
            zoo[0] = new Crab(33, "crab vasya", 10);
            

            Console.WriteLine("Hello World!");
        }

        static void Activity(Animal[] zoo)
        {
            foreach (var animal in zoo)
            {
                if(animal is IFlyable flyable)
                {
                    flyable.Fly(4);
                }
            }
        }

        static void ZooStatus(Animal[] zoo)
        {
            foreach (var animal in zoo)
            {
                if (!animal.Peaces)
                {
                    Console.WriteLine($"{animal.Name} is angry");
                }
            }
        }
    }
}
