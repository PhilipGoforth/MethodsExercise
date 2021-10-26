using System;
using System.Linq;

namespace MethodsExercise
{
    class Program
    {
        static void MyStory()
        {
            Console.WriteLine("Welcome to Methods Example!\n What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            string favColor = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string favAnimal = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            string favBand = Console.ReadLine();
            
            string result = $"{userName} Macdonald had a {favAnimal}, E-I-E-I-O\nOn that farm they had a {favColor} {favBand},E-I-E-I-O\n";
            Console.WriteLine(result);
        }
        //The methods below are for exercise 2
        static void Add(params int[] number)
        {
            Console.WriteLine("The sum of all digits is:");
            Console.WriteLine(number.Sum());
        }
        static void Sub(params int[] number)
        {
            Console.WriteLine("The subtracted value of all digits is:");
            Console.WriteLine(number.Aggregate(1,(a, b) => a - b));
        }
        static void Mult(params int[] number)
        {
            Console.WriteLine("The product of all digits is:");
            Console.WriteLine(number.Aggregate(1,(a, b) => a * b));
        }
        static void Div(params int[] number)
        {
            Console.WriteLine("The remainder of all digits is:");
            Console.WriteLine(number.Aggregate(1,(a, b) => a / b));
        }
        static void Mod(params int[] number)
        {
            Console.WriteLine("The modulus of all digits is:");
            Console.WriteLine(number.Aggregate(1,(a, b) => a % b));
        }
        static void Main(string[] args)
        {
            //exercise 1
            //MyStory();

            //exercise 2
            Console.WriteLine("Enter a long number:");
            //taking the user input and turning into an int array to use params with int[]
            int input = Convert.ToInt32(Console.ReadLine());
            int[] number = input.ToString().Select(o => Convert.ToInt32(o) - 48).ToArray();

            Add(number);
            Sub(number);
            Mult(number);
            Div(number);
            Mod(number);
        }
        
    }
    
}
