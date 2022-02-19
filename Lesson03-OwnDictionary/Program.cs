using System;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var dict = new DavidDictionary();
            dict.Add("Jacob", "Timms");
            dict.Add("Daniel", "Omajali");
            dict.Add("T", "Okereafor");
            dict.Add("David", "Mark");

            Console.WriteLine("Daniels surname is " + dict.Get("Daniel"));
            Console.WriteLine("David surname is " + dict.Get("David"));

            dict.Update("Daniel", "0");
            Console.WriteLine("Daniels surname is now " + dict.Get("Daniel"));
        }
    }


    public class DavidDictionary
    {
        private string[] _store;
        private int _arraySize = 20;

        public DavidDictionary()
        {
            _store = new string[_arraySize];
        }

        public void Add(string key, string value)
        {
            var keyAsInt = HashIt(key);
            var index = keyAsInt % _arraySize;
            _store[index] = value;
        }

        public int HashIt(string key)
        {
            return key.Length;
        }

        public int HashFirstChar(string key)
        {
            char res = key[0];
            var asInt = (int) res;
            return asInt;
        }

        public string Get(string key)
        {
            var keyAsInt = HashIt(key);
            var index = keyAsInt % _arraySize;
            return _store[index];
        }

        public void Update(string key, string value)
        {
            var keyAsInt = HashIt(key);
            var index = keyAsInt % _arraySize;
            _store[index] = value;
        }
    }
}
