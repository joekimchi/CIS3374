using System;
using System.Collections.Generic;

namespace Lab6
{
    public class Program
    {
        public static string[] board = new string[9];
        public static List<string> playersList = new List<string> { "X", "O" };

        public static string player1;
        public static string player2;

        public static int turnCount = 0;

        [STAThread]
        static void Main()
        {
            CreateBoard();

            //create new player 1
            CurrentPlayer();
            Console.WriteLine("Player 1 is: " + player1);
            Console.WriteLine("Turn count is: " + turnCount);

            //player 1 move
            MakeMove();
            Console.WriteLine(board[0].ToString());

            // call method to check if space is used
            SpaceInUse(board[0].ToString());

            //player switch
            ChangePlayer();
            Console.WriteLine("Player 2: " + player1);
            Console.WriteLine("Turn count is: " + turnCount);
        }

        public static void CreateBoard()
        {
            List<string> board = new List<string> { "+", "+", "+", "+", "+", "+", "+", "+", "+" };
            Console.WriteLine(board.ToString());
        }

        public static void CurrentPlayer()
        {
            Random random = new Random();

            int i = random.Next(playersList.Count);
            player1 = playersList[i];
            turnCount++;
        }

        public static void ChangePlayer()
        {
            string player;
            if (player1 == playersList[0])
            {
                player = player1;
                player1 = playersList[1];
                turnCount++;
            }
            else
            {
                player = player1;
                player2 = player1;
                player1 = playersList[0];
                turnCount++;
            }
        } 
        
        public static void MakeMove()
        {
            board[0] = playersList[0];
            board[1] = playersList[1];
            board[2] = playersList[0];
            board[3] = playersList[1];
            board[4] = playersList[0];
            board[5] = playersList[1];
            board[6] = playersList[0];
            board[7] = playersList[1];
            board[8] = playersList[0];
        }

        public static void SpaceInUse(string i)
        {
            bool check = false;

            if (i.Equals("+"))
            {
                check = false;
            }
            else
            {
                check = true;
            }
            Console.WriteLine(check);
        }
    }
}
