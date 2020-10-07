using System;

namespace Static
{
    public class Enemy
    {
        static Random generator = new Random();

        public string name = "";

        public int hp;

        public void SayHello()
        {
            hp += generator.Next(10);
            System.Console.WriteLine("Hello");
        }

    }
    
}
