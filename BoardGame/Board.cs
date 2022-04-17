using System;
using System.Collections.Generic;

namespace BoardGame
{
    public class Board
    {
        public List<List<string>> _board;
        public Board()
        {
            _board = new List<List<string>>();
            for (int x = 0; x < 8; x++)
            {
                var row = new List<string>();
                for (int y = 0; y < 8; y++)
                {
                    row.Add(" ");
                }
                _board.Add(row);
            }
        }

        public void Init()
        {
            PlaceBlackPieces();
            PlaceWhitePieces();
        }

        public void SetAtLocation(string location, string piece)
        {
            var coordinate = GetCoordinate(location[0], Int32.Parse(location[1].ToString()));
            _board[coordinate.Row][coordinate.Col] = piece;
        }
        public string GetAtLocation(string location)
        {
            var coordinate = GetCoordinate(location[0], Int32.Parse(location[1].ToString()));
            return _board[coordinate.Row][coordinate.Col];
        }

        public ChessPoint GetCoordinate(char letter, int number)
        {
            // a1 == 00
            var row = number - 1;
            var col = 0;
            switch (letter)
            {
                case 'b': 
                    col = 1;
                    break;
                case 'c': 
                    col = 2;
                    break;
                case 'd': 
                    col = 3;
                    break;
                case 'e': 
                    col = 4;
                    break;
                case 'f': 
                    col = 5;
                    break;
                case 'g': 
                    col = 6;
                    break;
                case 'h': 
                    col = 7;
                    break;
                default:
                    col = 0;
                    break;
            }

            return new ChessPoint(row, col);
        }

        private void PlaceWhitePieces()
        {
            for (int y = 0; y < 8; y++)
            {
                _board[0][y] = "w";
            }
        }

        private void PlaceBlackPieces()
        {
            for (int y = 0; y < 8; y++)
            {
                _board[7][y] = "b";
            }
        }

        public void DisplayBoard()
        {
            for (int x = 7; x >= 0; x--)
            {
                var row = $"{x+1}:";
                for (int y = 0; y < 8; y++)
                {
                    row = row + $" {_board[x][y]}";
                }

                Console.WriteLine(row);
            }


            Console.WriteLine("   a b c d e f g h");
        }
    }
}
