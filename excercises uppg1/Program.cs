using System;

namespace excercises_uppg1
{
    class Program
    {
        static void Main()
        {
            dog h1 = new dog();
            Console.WriteLine("Vad heter din hund?");
            h1.Name = Console.ReadLine();
            Console.WriteLine("Hur gammal är: " + h1.Name);
            h1.Age = Console.ReadLine();
            Console.WriteLine("Vad är:" + h1.Name + "för ras?");
            h1.Race = Console.ReadLine();

            Console.WriteLine(h1.Name);
            Console.ReadKey();
            Console.WriteLine(h1.Age);
            Console.ReadKey();
            Console.WriteLine(h1.Race);
            Console.ReadKey();
            


            dog.Bark();
            dog.Fetch();
            dog.Eat();
        }
        
    }
    class dog
    {
        private string name;
        private string age;
        private string race;

        public string Name
        {
            get { return name;}
            set { name = value;}
        }
        public string Age
        {
            get { return "Han är: " + age + "år gammal";}
            set { age = value;}
        }
        public string Race
        {
            get { return "Han är en: " + race;}
            set { race = value;}
        }

        

        public static void Bark()
        {
            Console.WriteLine("Figo Barks");
        }
        public static void Fetch()
        {   
            Console.WriteLine("Figo is only two years old! He loves to play fetch.");
        }
        public static void Eat()
        {
            Console.WriteLine("Figo is a Labrador, he eats a lot!");
        }

    }
}
