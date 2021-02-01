using System;
using System.Collections.Generic;

namespace BlockbusterMovieLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Blockbuster defunct = new Blockbuster();
            Console.WriteLine("Welcome to the Blockbuster liquidation sale");
            Movie rental;
            while(true)
            {
                Console.WriteLine("Please select a movie from the list:");
                rental = defunct.CheckOut();
                rental.PrintInfo();

                Console.WriteLine("Do you want to watch this movie? (Y/N)");
                if(Console.ReadLine().Trim().ToLower() == "y")
                {
                    Console.WriteLine("Do you want to watch the whole thing? (Y/N)");
                    if(Console.ReadLine().Trim().ToLower() == "y")
                    {
                        Console.Clear();
                        rental.PlayWholeMovie();
                    }
                    else
                    {
                        Console.Clear();
                        rental.Play();
                    }
                }
                else
                {
                    Console.Clear();
                    continue;
                }

                Console.WriteLine("Watch another movie?");
                if(Console.ReadLine().Trim().ToLower() == "y")
                {
                    Console.Clear();
                    continue;
                }
                else
                {
                    break;
                }
            }
            
        }
    }
}
