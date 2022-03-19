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
