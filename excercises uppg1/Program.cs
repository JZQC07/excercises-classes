using System;

namespace excercises_uppg1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            dog.Bark();
        }
        
    }
    class dog
    {
        private string name = "Figo";
        private int age = 2;
        private string race = "Labrador";

        public static void Bark()
        {
            Console.WriteLine("Figo Barks");
        }
        public static void Fetch()
        {   
            Console.WriteLine("Figo is only two years old! He loves to play fetch.");
        }
        public static void eat()
        {
            Console.WriteLine("Figo is a {0}, he eats a lot!");
        }

    }
}
