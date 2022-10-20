using System;
using System.Collections;

namespace AdvCSAnimals
{
    class Program
    {
        private static FileOutput outFile = new FileOutput("animals.txt");
        private static FileInput fileInput = new FileInput("animals.txt");

        public static void Main(string[] args)
        {
            List<Talkable> zoo = new List<Talkable>();
            zoo.Add(new Dog("Bean",true));
            zoo.Add(new Cat( "Charlie",9));
            zoo.Add(new Teacher("Stacy Read",44));
            
            
            
        }

        private static void printOut(Talkable p) {
            Console.WriteLine(p.getName() + " says=" + p.talk());
             outFile.fileWrite(p.getName() + " | " + p.talk());
        }
        
    }
}

