using System;

namespace MethodsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Methods Example!\n What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            string favColor = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string favAnimal = Console.ReadLine();
            Console.WriteLine("What id your favorite band?");
            string favBand = Console.ReadLine();

            myStory(userName, favColor, favAnimal, favBand);

            static void myStory(string userName, string favColor, string favAnimal, string favBand)
            {
               string result = $"{userName} Macdonald had a {favAnimal}, E-I-E-I-O\nOn that farm they had a {favColor} {favBand},E-I-E-I-O";
                Console.WriteLine(result);
            }

        }
        
    }
    
}
