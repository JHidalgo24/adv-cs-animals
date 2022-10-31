using AdvCSAnimals;

namespace adv_cs_animals;

public class UserInput
{


    public Talkable userPrompt()
    {
        Console.WriteLine("What kind of Animal do you want to create? (Dog, or Cat)");
        string animal = Console.ReadLine();
        
        switch (animal)
        {
            case "Dog":
                string friendly = "";
                string dogName = "";
                Console.WriteLine("What is the name of the Dog?");
                dogName = Console.ReadLine();
                Console.WriteLine("Is he/she friendly? (Y/N)");
                friendly = Console.ReadLine().Substring(0, 1).ToLower();
                Console.WriteLine(friendly);
                var contains = friendly.Contains("y") || friendly.Contains("n");
                while (!contains)
                {
                    Console.WriteLine("Is he/she friendly? (Y/N)");
                    friendly = Console.ReadLine().Substring(0, 1).ToLower();
                    contains = friendly.Contains("y") || friendly.Contains("n");
                }
                Talkable doggy = new Dog(dogName,friendly.Equals("y"));
                return doggy;
                break;
            case "Cat":
                Console.WriteLine("What is the name of the Cat?");
                var catName = Console.ReadLine();
                Console.WriteLine("How many mice has the cat destroyed?");
                var mice = Console.ReadLine();
                double miceTotal;
                
                while (!Double.TryParse(mice, out miceTotal))
                {
                    Console.WriteLine($"Could not convert {mice} try again");
                    mice = Console.ReadLine();
                }
                Talkable kitty = new Cat(catName,(int)miceTotal);
                return kitty;
                break;
            default:
                Console.WriteLine("Unable to detect Dog or Cat");
                return null;
                break;
            
        }

    }
    
    
    
    

}