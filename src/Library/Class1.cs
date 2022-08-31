using System;
using System.IO;
using System.Text;

namespace PII_Game_Of_Life
{
    public class BoardInitializer //Inicializa el tablero desde un archivo de texto
    {

        /*
        public static bool[,] gameBoard { get; }
        public static int boardWidth { get; } = gameBoard.GetLength(0);
        public static int boardHeight { get; } = gameBoard.GetLength(1);
        public BoardInitializer()
        {
            string url = @"..\..\assets\board.txt";
            string content = File.ReadAllText(url);
            string[] contentLines = content.Split("\n");
            bool[,] gameBoard = new bool[contentLines.Length, contentLines[0].Length];
            for (int y = 0; y < contentLines.Length; y++)
            {
                for (int x = 0; x < contentLines[y].Length; x++)
                {
                    if (contentLines[y][x] == '1')
                    {
                        gameBoard[x, y] = true;
                    }
                    else
                    {
                        gameBoard[x, y] = false;
                    }
                }
            }

        }
        */
    }

    public class Board //Representa el estado del juego y juega al juego
    {

    }

    public class BoardPrinter //Imprime el tablero
    {

    }

}