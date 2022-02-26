using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //string message = "I will not skaeboard in the halls.".ToUpper());

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i+1}. I will not skateborad in the halls.".ToUpper());
            }
        }
    }
}
