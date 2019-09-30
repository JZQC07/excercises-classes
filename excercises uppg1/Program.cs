using System;

namespace excercises_uppg1
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Alla hundar är Labradorer och alla hundar har 4 ben!");
            Dog h1 = new Dog();
            Console.WriteLine("Vad heter den första hunden?");
            h1.Name = Console.ReadLine();
            Console.WriteLine("Hur gammal är {0}?", h1.Name);
            h1.Age = int.Parse(Console.ReadLine());
            Console.WriteLine(h1.Name + " är " + h1.Age + " år gammal, är en " + h1.Race + " och har " + h1.Legs + " ben");
            
            Dog.Bark();
        }
    }
    public class Dog
    {
        public Dog() //Konstruktor
        {
            Console.WriteLine("En ny hund har skapats!");

            race = "Labrador";
            legs = 4;
        }
        private int age;
        private string name;
        private string race;
        private int legs;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public int Legs
        {
            get { return legs; }
            set { legs = value; }
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
            Console.WriteLine("Tryck valfri tangent för att skapa en ny hund.");
            Console.ReadKey();

            Dog h2 = new Dog();
            Console.WriteLine("Vad heter den andra hunden?");
            string name = Console.ReadLine();
            Console.WriteLine("Hur gammal är {0}", name);
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Alla hundar kommer alltid att ha 4 ben!!!"); //Tack vare konstruktorn
            Console.WriteLine(name + " är " + age + " år gammal, är en {0} ", h2.race + " och har " + h2.legs + " ben");
            Console.WriteLine("Han skäller högt!");
            Console.ReadKey();

            Dog.Fetch();
        }
        public static void Fetch()
        {
            Console.WriteLine("Tryck valfri tangent för att skapa en ny hund.");
            Console.ReadKey();
            
            Dog h3 = new Dog();

            Console.WriteLine("Vad heter den tredje hunden?");
            string name = Console.ReadLine();
            Console.WriteLine("Hur gammal är {0}", name);
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(name + " är " + age + " år gammal, är en " + h3.race + " och har " + h3.legs + " ben");
            Console.WriteLine("Han skäller högt!");
            Console.ReadKey();
        }
    }
}
