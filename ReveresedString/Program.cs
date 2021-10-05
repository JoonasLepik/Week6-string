using System;

namespace ReveresedString
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kpsib kasutajal sisestada eesnimi
            //programm kuvab kasutajanime tagurpidi
            Console.WriteLine("Enter firstname:");
            string firstname = Console.ReadLine();
            for (int i = firstname.Length-1; i>=0; i--)
            {
                Console.WriteLine(firstname[i]);
            }
        }
    }
}
