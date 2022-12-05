using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Password()
        {
            bool Valid = false;
            while (Valid == false)
            {
                Console.WriteLine("Please enter a password");
                string UInput = Console.ReadLine();
                if (UInput.Length >= 8 & UInput.Any(char.IsUpper) & UInput.Any(char.IsLower) & UInput.Any(char.IsNumber))
                {
                    Console.WriteLine(UInput, " Is a good password");
                    Valid = true;
                }
                else
                {
                    Console.WriteLine("Please write a stronger password");
                }
            }
        }
        static void Main(string[] args)
        {
            Password();
        }
    }
}
