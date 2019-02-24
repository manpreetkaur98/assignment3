using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_coffee_problem_solution_
{
    class Program
    {
        static void Main(string[] args)
        {
            string AgainChoice = "";
            int TotalCoffeeCost = 0;,,,,,,,,,,,,,,,,,
            do
            {
                
                Console.WriteLine("1-small, 2-Medium, 3-Large");
                int UserChoice = int.Parse(Console.ReadLine());

                switch (UserChoice)
                {
                    case 1:
                        TotalCoffeeCost += 1;
                        break;
                    case 2:
                        TotalCoffeeCost += 2;
                        break;
                    case 3:
                        TotalCoffeeCost += 3;
                        break;
                    default:
                        Console.WriteLine("Your Choice {0} is invalid", UserChoice);
                        break;


                }
                

                do
                {
                    Console.WriteLine("Do you Want to buy another coffee");
                    AgainChoice = Console.ReadLine();
                    if (AgainChoice != "yes" && AgainChoice != "no")
                    {
                        Console.WriteLine("Invalide Choice");
                    }
                } while (AgainChoice != "yes" && AgainChoice != "no");

            } while (AgainChoice == "yes");
            Console.WriteLine("ThankYou");
            Console.WriteLine("Bill Amount={0}", TotalCoffeeCost);
        }
    }
}
