using System.Security.Cryptography.X509Certificates;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var r = new Random();
            //var favNumber = r.Next(1, 1000);
            //int userInput;
            //var counter = 0;

            //do
            //{

            //    Console.WriteLine("Pick a number from 1 to 1000.");
            //    userInput = int.Parse(Console.ReadLine());

            //    if (userInput < favNumber)
            //    {
            //        Console.WriteLine($"{userInput} is too low.");
            //    }
            //    else if (userInput > favNumber)
            //    {
            //        Console.WriteLine($"{userInput} is too high.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"You guessed it!");
            //    }

            //    counter++;
            //    Console.WriteLine($"You have guessed {counter} time(s)");

            //} while (userInput != favNumber);

            Console.WriteLine("What is your favorite subject?");

            string subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                case "geometry":
                    Console.WriteLine("Math is the worst!");
                    break;
                case "science":
                case "biology":
                    Console.WriteLine("Science is pretty cool!");
                    break;
                case "PE":
                case "phys ed":
                case "physical education":
                    Console.WriteLine("PE is the most fun!");
                    break;
                case "history":
                    Console.WriteLine("History is old news.");
                    break;
                case "english":
                    Console.WriteLine("English is important.");
                    break;
                default:
                    Console.WriteLine("I don't know that subject.");
                    break;
            }




                    
        }
    }
}
