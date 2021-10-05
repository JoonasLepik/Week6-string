using System;

namespace StringsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloworld = "Hello World!";
            //programm kuvab konsoolis sõna 1 tähte ja viimast tähte.
            Console.WriteLine("Hello World!");            
            Console.WriteLine(helloworld[0]);
            Console.WriteLine(helloworld[helloworld.Length-2]);
            Console.ReadLine();
            

        }
    }
}
