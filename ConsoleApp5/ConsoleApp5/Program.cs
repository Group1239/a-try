using System;

namespace ConsoleApp5
{
    public interface IAnimal
    {
        string GetDescription();
    }

    public interface IHealth
    {
        string GetHealth();
    }

    class Cat : IAnimal
    {
        public string GetDescription()
        {
            return "I'm a cat";
        }
    }

    class Soldier : IHealth
    {
        public string GetHealth()
        {
            return "I am healthy.";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cat myCat = new Cat();

            Soldier mySoldier = new Soldier();

            Console.WriteLine(myCat.GetDescription());

            Console.WriteLine(mySoldier.GetHealth());

            Console.Write("Press Enter to continue!");
            Console.ReadLine();
        }
    }

}
