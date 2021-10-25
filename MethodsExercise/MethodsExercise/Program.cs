using System;
using System.Linq;

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

            MyStory(userName, favColor, favAnimal, favBand);

            Console.WriteLine("Enter a number:");
            int input = Convert.ToInt32(Console.ReadLine());
            int[] number = input.ToString().Select(o => Convert.ToInt32(o) - 48).ToArray();

            Console.WriteLine($"The sum of all digits is:");
            Add(number);
            Console.WriteLine($"The subtracted value of all digits is:");
            Sub(number);
            Console.WriteLine($"The product of all digits is:");
            Mult(number);
            Console.WriteLine($"The remainder of all digits is:");
            Div(number);
            Console.WriteLine($"The modulus of all digits is:");
            Mod(number);

            static void MyStory(string userName, string favColor, string favAnimal, string favBand)
            {
               string result = $"{userName} Macdonald had a {favAnimal}, E-I-E-I-O\nOn that farm they had a {favColor} {favBand},E-I-E-I-O";
                Console.WriteLine(result);
            }
            static void Add(params int[] number)
            {
                Console.WriteLine(number.Sum());
            }
            static void Sub(params int[] number)
            {
                Console.WriteLine(number.Aggregate(1, (a, b) => a - b));
            }
            static void Mult(params int[] number)
            {
                Console.WriteLine(number.Aggregate(1, (a, b) => a * b));
            }
            static void Div(params int[] number)
            {
                Console.WriteLine(number.Aggregate(1, (a, b) => a / b));
            }
            static void Mod(params int[] number)
            {
                Console.WriteLine(number.Aggregate(1, (a, b) => a % b));
            }

        }
        
    }
    
}
