using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("| Welcome to TicTacToe Game |");
            Console.WriteLine("-----------------------------");
            string[] square = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            int numTurns = 0;
            bool isPlayer1Turn = true;

            while (!CheckWinner() && numTurns != 9)
            {
                printBoard();

                if (isPlayer1Turn)
                {
                    Console.WriteLine("Player 1 turn");
                }
                else
                {
                    Console.WriteLine("Player 2 turn");
                }

                string choice = Console.ReadLine();

                if (square.Contains(choice) && choice != "X" && choice != "O")
                {
                    int squareIndex = Convert.ToInt32(choice) - 1;

                    if (isPlayer1Turn)
                    {
                        square[squareIndex] = "X";
                    }
                    else
                    {
                        square[squareIndex] = "O";
                    }
                    numTurns++;
                }
                isPlayer1Turn = !isPlayer1Turn;
            }

            bool CheckWinner()
            {
                bool row1 = square[0] == square[1] && square[1] == square[2];
                bool row2 = square[3] == square[4] && square[4] == square[5];
                bool row3 = square[6] == square[7] && square[7] == square[8];
                bool column1 = square[0] == square[3] && square[3] == square[6];
                bool column2 = square[1] == square[4] && square[4] == square[7];
                bool column3 = square[2] == square[5] && square[5] == square[8];
                bool forward = square[0] == square[4] && square[4] == square[8];
                bool backward = square[2] == square[4] && square[4] == square[6];

                return row1 || row2 || row3 || column1 || column2 || column3 || forward || backward;
            }

            if(CheckWinner() )
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("YOU WIN!");
                Console.WriteLine("-----------------------");
                printBoard();
            }
            else
            {
                Console.WriteLine("Tie!");
            }


            void printBoard()
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write("|");
                        Console.Write(square[i + i + i + j]);
                        Console.Write('|');
                    }
                    Console.WriteLine();
                    Console.WriteLine("---------");
                }
            }
        Console.ReadKey();
        }
    }
}
