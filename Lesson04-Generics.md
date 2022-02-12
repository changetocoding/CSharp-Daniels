###




# Class code

```cs
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
