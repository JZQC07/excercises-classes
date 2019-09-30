using System;

namespace excercises_uppg1
{
    public class Program
    {
        public static void Main()
        {
            Dog h1 = new Dog();
            Console.WriteLine(h1.Name);
            Console.WriteLine(h1.Age);
            Console.WriteLine(h1.Race);
            
            Dog.Bark();
        }
    }
    public class Dog
    {
        public Dog() //Konstruktor
        {
            Console.WriteLine("En ny hund har skapats!");

            name = "Harald";
            age = 12;
            race = "Labrador";
        }

        private int age;
        private string name;
        private string race;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Race
        {
            get { return race; }
            set { race = value; }
        }
        public static void Bark()
        {
            Dog h2 = new Dog();
            Console.WriteLine("Vad heter den andra hunden?");
            string name = Console.ReadLine();
            Console.WriteLine("Hur gammal är {0}", name);
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vad är {0} för ras?", name);
            string race = Console.ReadLine();

            Console.WriteLine(name + "är " + age + " år gammal, och är en {0}", race);
            Console.WriteLine("Han skäller högt!");
            Console.ReadKey();

            Dog.Fetch();
        }
        public static void Fetch()
        {
            Dog h3 = new Dog();

            Console.WriteLine("Vad heter den tredje hunden?");
            string name = Console.ReadLine();
            Console.WriteLine("Hur gammal är {0}", name);
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vad är {0} för ras?", name);
            string race = Console.ReadLine();

            Console.WriteLine(name + "är " + age + " år gammal, och är en {0}", race);
            Console.WriteLine("Han skäller högt!");
            Console.ReadKey();
        }
    }
}
