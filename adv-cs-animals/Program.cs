using System;
using System.Collections;

namespace AdvCSAnimals
{
    class Program
    {
        private static FileOutput outFile;
        private static FileInput fileInput;

        public static void Main(string[] args)
        {
            List<Talkable> zoo = new List<Talkable>();
            zoo.Add(new Dog("Bean",true));
            zoo.Add(new Cat( "Charlie",9));
            zoo.Add(new Teacher("Stacy Read",44));
            
            foreach (var thing in zoo) {
                printOut(thing);
            }
            
            FileInput inData = new FileInput("animals.txt");
            string? line;
            while ((line = inData.FileReadLine()) != null) {
                Console.WriteLine(line);
            }
            
        }

        private static void printOut(Talkable p)
        {
            outFile = new FileOutput("animals.txt");
            Console.WriteLine(p.getName() + " says=" + p.talk());
             outFile.fileWrite(p.getName() + " | " + p.talk());
        }
        
    }
}

