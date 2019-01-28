using System;

namespace LikePizza
{
    class Program
    {
        static void Main(string[] args)
        {
            string likePizza;

            Console.WriteLine("Do you like pizza? (yes/no)");
            likePizza = Console.ReadLine();

            if (likePizza == "yes")
            {
                Console.WriteLine("You like Pizza");
            }
            if (likePizza == "no")
            {
                Console.WriteLine("You don't like Pizza");
            }
            else
            {
                Console.WriteLine("You entered an invalid response, please answer yes or no");
            }
            Console.ReadLine();
        }
    }
}
