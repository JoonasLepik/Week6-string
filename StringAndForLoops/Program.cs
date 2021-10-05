using System;

namespace StringAndForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter firstname:");
            string firstname = Console.ReadLine();
            for (int i = 0; i < firstname.Length; i++)
            {
                Console.WriteLine(firstname[i]);
            }

        }
    }
}
