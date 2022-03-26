# Code

Program
```cs
    class Program
    {
        static void Main(string[] args)
        {
            var phonebook = new PhoneBook();
            
            while (true)
            {
                var input = Console.ReadLine();
                var commandList = input.Split(" ");
                var command = commandList[0];

                if (command.Equals("STORE", StringComparison.CurrentCultureIgnoreCase))
                {
                    var no = Convert.ToInt64(commandList[2]);
                    phonebook.Add(commandList[1], no);
                    Console.WriteLine("OK");
                }
                else if (command.Equals("GET", StringComparison.CurrentCultureIgnoreCase))
                {
                    try
                    {
                        var no = phonebook.Get(commandList[1]);
                        Console.WriteLine($"OK - {no:00000000000}");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"NOT FOUND");
                    }
                }
            }
            
        }
    }
```

Phonebook.cs
```cs
    class PhoneBook
    {
        private Dictionary<string, long> _dict;

        public PhoneBook()
        {
            _dict = new Dictionary<string, long>();
        }

        public void Add(string name, in long no)
        {
            _dict.Add(name, no);
        }

        public long Get(string name)
        {
            return _dict[name];
        }
    }

```

# Chess
```cs
    class Program
    {
        static void Main(string[] args)
        {
            var board = new Board();
            board.Init();
            board.DisplayBoard();
            Console.WriteLine(board.GetLoc('b', 1));
        }
    }
```
board
```cs
    class Board
    {
        private List<List<string>> _board;
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
                _board[1][y] = "wP";
            }

            _board[0][0] = "wR";
            _board[0][1] = "wN";
            _board[0][2] = "wB";
            _board[0][3] = "wQ";
            _board[0][4] = "wK";
            _board[0][5] = "wB";
            _board[0][6] = "wN";
            _board[0][7] = "wR";
        }

        private void PlaceBlackPieces()
        {
            for (int y = 0; y < 8; y++)
            {
                _board[6][y] = "bP";
            }

            _board[7][0] = "bR";
            _board[7][1] = "bN";
            _board[7][2] = "bB";
            _board[7][3] = "bQ";
            _board[7][4] = "bK";
            _board[7][5] = "bB";
            _board[7][6] = "bN";
            _board[7][7] = "bR";
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
            Console.WriteLine("   a  b  c  d  e  f  g  h");
        }
    }
```

