###




# Class code

```cs
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal myclass = new Spider();

            var genericClass = new DanielAndTochiGenric<string>("test");
            object res = genericClass.GetInput(); // "test"


            var genericClass2 = new DanielAndTochiGenric<int>(1);
            int res2 = genericClass2.GetInput(); // 1

            var genericClass3 = new DanielAndTochiGenric<int>(10);
            int res3 = genericClass3.GetInput(); // 10
            var total = res2 + res3;
        }
    }
    


    // in below everytime you see TInput it will get replaced with *string*
    //var genericClass = new DanielAndTochiGenric<string>("test");
    // in below everytime you see TInput it will get replaced with *int*
    //var genericClass = new DanielAndTochiGenric<int>(100);

    public class DanielAndTochiGenric<TInput>
    {
        private TInput _input;

        public DanielAndTochiGenric(TInput input)
        {
            _input = input;
        }

        public TInput GetInput()
        {
            return _input;
        }
    }
```
