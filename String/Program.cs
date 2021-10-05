using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            //Progamm küsib kasjutajal sisestada eesnimi
            //Programm kuvab kasjutaja eesnime esimest tähte
            //programm kuvab kasutaja eesnime viimast tähte.
            Console.WriteLine("Enter your firstname");
            string firstname = Console.ReadLine();
            Console.WriteLine(firstname[0]);
            int firstnamelength = firstname.Length;
            Console.WriteLine($"Your name is {firstnamelength} letters long.");
            //Vimase tähe indeks = firstNamelenght - 1
            Console.WriteLine(firstname[firstnamelength -1]);


        }
    }
}
