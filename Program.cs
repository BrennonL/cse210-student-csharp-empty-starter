using System;
using System.Collections.Generic;
namespace Cse210Starter
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            List<string> Board = new List<string> (){"1", "2", "3", "4",
            "5", "6", "7", "8", "9"};
            string Player = "o";

            bool Winner = false;
            int Turn = 0;

            do
            {
                // Use the BoardMaker function to create the playing board
                BoardMaker(ref Board);
                Player = ChangeTurn(Player);
                Console.WriteLine(Player);

                UpdatePlayersChoice(ref Board, Player);
                x++;

                if(Board[0] == Board[1] && Board[0] == Board[2] ||
                Board[3] == Board[4] && Board[3] == Board[5] ||
                Board[6] == Board[7] && Board[6] == Board[8] ||
                Board[0] == Board[3] && Board[0] == Board[6] ||
                Board[1] == Board[4] && Board[1] == Board[7] ||
                Board[2] == Board[5] && Board[2] == Board[8] ||
                Board[0] == Board[7] && Board[0] == Board[8] ||
                Board[2] == Board[7] && Board[0] == Board[2])

                {
                    Winner = true;
                }
                Turn ++;

            }while (!Winner || Turn != 9);

            Console.WriteLine("Good Game. Thanks for playing!");
 

            
            // Write your code here
        }





        //Create Function that makes the board
        static void BoardMaker (ref List<string> Board)
        // This function doesn't take any parameters but it references the list named
        //"Board"
        {
        
            Console.WriteLine($"{Board[0]}|{Board[1]}|{Board[2]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{Board[3]}|{Board[4]}|{Board[5]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{Board[6]}|{Board[7]}|{Board[8]}");

        }







        //This Function changes player's turn
        static string ChangeTurn (string Player)
        {

            // This if else swiches the player's turn
            if (Player == "x")
            {
                Player = "o";

            }
            else if(Player == "o")
            {
                Player = "x";
            }

            return Player;
        }







        // This function Gets user input and updates board
        static void UpdatePlayersChoice(ref List<string> Board, string player)
        {
            Console.Write($"{player}'s turn to choose a square (1-9):");
            string ChoiceString = Console.ReadLine();
            int Choice = int.Parse(ChoiceString);
            Board[Choice - 1] = player;

        }

        //Create function that determines winner


        
    }
}
