```cs
public class Class2
    {
        // Constructor signature: [Access Type] name(){}
        public Class2()
        {
            
        }

        // method signature: [Access Type] [returnType] name(params){}
        // void is a return type aka no return type
        public int Birthday(int age)
        {
            return age + 1;
        }
    }

```
In C# classes and methods names begin with capitals

#
Classes are contracts. Instance is object you can play with.

## To create an instance
```cs
            var it = new Class2();
```

## Static vs instance methods
