using System;

namespace BoardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var board = new Board();
            board.Init();
            board.DisplayBoard();
            Console.WriteLine(board.GetAtLocation("b3"));
        }
    }
}
