using System;

namespace Practice_3
{
    class CustomException : Exception
    {
        public CustomException(string message) : base(message)
        {
        }
    }
    class Practice_3
    {
        static void Main(string[] args)
        {
            try 
            {
            Console.WriteLine("Enter One Character:");
            string three = Console.ReadLine();
            Console.WriteLine("Enter Another Character:");
            string two = Console.ReadLine();
            Console.WriteLine("Enter One Last Character:");
            string one = Console.ReadLine();
            if (three == null || three.Length > 1)
            {
                Console.WriteLine("Only one character");
                throw new CustomException($"\nYou put more than one character, in the first input, Follow Instructions, or you entered NOTHING! \nError here: {three}");
            }
            if (two == null || two.Length > 1)
            {
                Console.WriteLine("Only one character");
                throw new CustomException($"\nYou put more than one character, in the second input, Follow Instructions, or you entered NOTHING! \nError here: {two}");
            }
            if (one == null || one.Length > 1)
            {
                Console.WriteLine("Only one character");
                throw new CustomException($"\nYou put more than one character, in the Third input, Follow Instructions, or you entered NOTHING! \nError here: {one}");
            }
            Console.WriteLine($"{one}{two}{three}!");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Caught an Exception:\n{ex.Message}");
            }
        }
    }
}