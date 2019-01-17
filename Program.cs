using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceDiceBaby2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while (run == true) //loop to restart program 
            {

                Console.WriteLine("Welcome Grand Circus Casino!!!!");
                DiceRoll();//call for Dice function
                run = Continue();// call for the recuring continue method
            }
        }

        public static void DiceRoll()//method for dice roll using the Random method
        {       
                Console.WriteLine("Would you like to roll the dice? (y/n)");
                string answer = Console.ReadLine().ToLower();

                if (answer == "y")
                {
                    Random numberToGuess = new Random();
                    Console.WriteLine("Enter the sides");
                    int UserDiceSide = int.Parse(Console.ReadLine());
                    UserDiceSide = numberToGuess.Next(1, UserDiceSide);

                    Console.WriteLine($"Dice {UserDiceSide}");
                    UserDiceSide = numberToGuess.Next(1, UserDiceSide);
                    Console.WriteLine($"Dice {UserDiceSide}");
                  
                }

                else if(answer == "n")
                {
                    Console.WriteLine("ugh fine whatever");
                   
                }

                else
                {
                    Console.WriteLine("Sorry I didn't catch that."); 
                }

        }

        public static bool Continue()//continue method
        {
            Console.WriteLine("Would you like to run this program agian?(y/n)");
            string input = Console.ReadLine().ToLower();
            bool stuff;
            if (input == "y")
            {
                stuff = true;//y makes the bool method true which causes the program to rerun
            }
            else if (input == "n")
            {
                stuff = false; //n makes bool method false and causes the program to end
            }
            else
            {
                Console.WriteLine("Sorry I didn't catch that. Please try agian (y/n)");
                stuff = Continue();//anything other then y or n will cause the method to recure
            }

            return stuff;
        }
    }
}
