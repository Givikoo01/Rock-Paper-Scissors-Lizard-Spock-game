using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class ShowWinner
    {
        //getting user choice and returning it
        public string getUserChoice()
        {
            char choice;
            while (true)
            {
                Console.Write("Enter your move: ");
                if (char.TryParse(Console.ReadLine(), out choice))
                {
                    if ((choice > '0' && (int)choice <= '5'))
                        break;
                    else if (choice == '?' || choice == '0')
                        break;
                }
                Console.WriteLine("Invalid input. Please enter a number between 0 and 5 or press ? to help.");
            }
            return choice.ToString();
        }

        //showing the winner message, displaying the table and exiting the program
        public ShowWinner(string[] moves, int computerInput, string key)
        {
            while (true)
            {
                string userChoice = getUserChoice();
                if (userChoice == "0")
                {
                    Console.WriteLine("Exiting the program! ");
                    return;
                } 
                if (userChoice == "?")
                {
                    RulesHelp.ShowRulesTable(moves);
                }
                else
                {
                    //choice converted to int
                    int c = int.Parse(userChoice);
                    Console.WriteLine("Your move: " + $"{moves[c - 1]}");
                    Console.WriteLine("Computer move: " + $"{moves[computerInput - 1]}");
                    Console.WriteLine(GameRules.Winner(c, computerInput, 5));
                    Console.WriteLine("HMAC key: " + key);
                    return;
                }
            }
        }
    }
}
