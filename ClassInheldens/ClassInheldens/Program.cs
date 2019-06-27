using System;

namespace ClassInheldens
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] zoo = new Animal[10];
            zoo[0] = new Crab(33, "crab Vasya", 10);
            zoo[1] = new Bee(0.02, "bee Vanya");
            zoo[2] = new Ant(0.03, "ant Varvar");
            zoo[3] = new Duck(136, "duck Inokentiy");
            zoo[4] = new Hummingbird(11, "hummingbird Dasha");
            zoo[5] = new Сrayfish(29, "crayfish Riko",3);
            zoo[6] = new Bee(0.01, "bee Veronika");
            zoo[7] = new Duck(0.02, "duck Kolya");
            zoo[8] = new Ant(0.02, "ant Ilona");
            zoo[9] = new Bee(0.02, "bee Masha");
            ActivityFly(zoo);
            ActivitySwim(zoo);
            ActivityWalk(zoo);
            StickCountPickUp(zoo);
            PollinateFlowers(zoo);
            Eating(zoo);
            ZooStatus(zoo);
            Console.ReadKey();
        }
        static void Eating(Animal[] zoo)
        {
            for(int i = 0; i < zoo.Length; i++)
            {
                zoo[i].Eat("meat", 0.01);
            }
        }

        static void ActivityFly(Animal[] zoo)
        {
            foreach (var animal in zoo)
            {
                if(animal is IFlyable flyable)
                {
                    flyable.Fly(13);
                }
            }
        }

        static void ActivitySwim(Animal[] zoo)
        {
            foreach (var animal in zoo)
            {
                if (animal is ISwimmable swiming)
                {
                    swiming.Swim(4);
                }
            }
        }
        static void ActivityWalk(Animal[] zoo)
        {
            foreach (var animal in zoo)
            {
                if (animal is IWalking walking)
                {
                    walking.Walk(0.9);
                }
            }
        }
        static void StickCountPickUp(Animal[] zoo)
        {
            foreach (var animal in zoo)
            {
                if (animal is IPikUpStick pickUp)
                {
                    pickUp.Stick(30);
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
                else
                {
                    Console.WriteLine($"{animal.Name} is pleased");
                }
            }
        }
        static void PollinateFlowers (Animal[] zoo)
        {
            foreach (var animal in zoo)
            {
                if(animal is IPollination poll)
                {
                    poll.Pollinate(17);
                }
            }
        }
    }
}
