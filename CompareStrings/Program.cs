using System;

namespace CompareStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime ja perekonanime
            //program võrdleb sisestatud andmeid omavahel
            //programm kuvab konsoolis, kumb on pikkem kas ees nimi või perekonnanimi
            Console.WriteLine("Please insert your firstname");
            string Firstname = Console.ReadLine();
            Console.WriteLine("Plese insert your last name");
            string Lastname = Console.ReadLine();
            if (Firstname.Length > Lastname.Length)
            {
                Console.WriteLine("Your firstname is longer then your last name.");
            }
            else if (Firstname.Length < Lastname.Length)
            {
                Console.WriteLine("Your lastname is longer than your firstname.");
            }
            else
            {
                Console.WriteLine("Both of your names are the same lenght.");
            }
        }
    }
}
