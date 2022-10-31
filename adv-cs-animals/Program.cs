using System;
using System.Collections;
using adv_cs_animals;

namespace AdvCSAnimals
{
    class Program
    {
        private static FileOutput outFile;
        private static FileInput fileInput;

        public static void Main(string[] args)
        {

            UserInput userInput = new UserInput();
            List<Talkable> zoo = new List<Talkable>();
            zoo.Add(new Dog("Bean",true));
            zoo.Add(new Cat( "Charlie",9));
            zoo.Add(new Teacher("Stacy Read",44));
            
            var pet = userInput.userPrompt();
            if (pet == null)
            {
                Console.Write("Your pet was not added to the list");
                Console.WriteLine("");
            }
            else{zoo.Add(pet);}
                
            
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
             outFile.FileWrite(p.getName() + " | " + p.talk());
        }
        
    }
}

