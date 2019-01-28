using System;

namespace LikePizza
{
    class Program
    {
        static void Main(string[] args)
        {
            string likePizza;
            bool validResponse;

            do
            {
                Console.WriteLine("Do you like Pizza? (yes/no)");
                likePizza = Console.ReadLine();

                if (likePizza == "yes")
                {
                    validResponse = true;
                    Console.WriteLine("You like Pizza!");
                }

                else if (likePizza == "no")
                {
                    validResponse = true;
                    Console.WriteLine("You don't like Pizza!");
                }

                else
                {
                    validResponse = false;
                    Console.WriteLine("You entered an invalid response, please type yes or no");
                    Console.WriteLine();
                }
            } while (validResponse == false);
            Console.ReadKey();
        }
    }
}
