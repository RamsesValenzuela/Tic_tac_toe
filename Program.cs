using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tres_En_Linea
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int player = 2;
            int input = 0;
            bool isCorrect = true;



            CreateBoard();

            do
            {
                if(player == 2)
                {
                    player = 1;
                    drawXorO(player, input); 
                }else if( player == 1)
                {
                    player = 2;
                    drawXorO(player, input);

                }

                do
                {
                    Console.WriteLine("\n Player {0} choose a kbox to check...", player);
                    input = Convert.ToInt32(Console.ReadLine());

                } while (!isCorrect);

            } while (true);


        }


        //this method found the player
        public static void drawXorO(int player, int input)
        {
            char mark = ' ';

            if (player == 1)
            {
                mark = 'X';
            }
            else if (player == 2)
            {
                mark = 'O';
            }
            switch (input)
            {
                case 1:
                    gameBoard[0, 0] = mark; break;
                case 2:
                    gameBoard[0, 1] = mark; break;
                case 3:
                    gameBoard[0, 2] = mark; break;
                case 4:
                    gameBoard[1, 0] = mark; break;
                case 5:
                    gameBoard[1, 1] = mark; break;
                case 6:
                    gameBoard[1, 2] = mark; break;
                case 7:
                    gameBoard[2, 0] = mark; break;
                case 8:
                    gameBoard[2, 1] = mark; break;
                case 9:
                    gameBoard[2, 2] = mark; break;
            }
        }

        //Array que contiene las varaibales del juego
        static char[,] gameBoard =
        {
            {'1','2','3'},
            {'4','5','6'},
            {'7','8','9'},
};

        //Metodo que genera el tablero de 3 en linea.
        public static void CreateBoard()
        {
            Console.WriteLine("     |     |");
            Console.WriteLine("  {0}  |  {1}  |  {2}", gameBoard[0,0], gameBoard[0, 1], gameBoard[0, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |");
            Console.WriteLine("  {0}  |  {1}  |  {2}", gameBoard[1, 0], gameBoard[1, 1], gameBoard[1, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |");
            Console.WriteLine("  {0}  |  {1}  |  {2}", gameBoard[2, 0], gameBoard[2, 1], gameBoard[2, 2]);
            Console.WriteLine("     |     |");
        }
    }
}
