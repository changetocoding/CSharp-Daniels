```cs
    public class Class2
    {
        // field signature : [access modifer] (optional [static]) [Type] name (opt =)
        // David's standard is name begins with _ so easy to recognise
        private int _myField = 10;
        private static int _howManyBirthdaysCalled = 0;

        // Constructor signature: [Access Type] name(){}  - name must match class name
        // Called whenever a new happens Allows you to initalise you class with data
        // Think of it as your setup
        public Class2()
        {
            _myField = 0;
        }

        // method signature: [Access Type] [returnType] name(params){}
        // void is a return type aka no return type
        public int Birthday(int age)
        {
            _howManyBirthdaysCalled = _howManyBirthdaysCalled + 1;
            _myField = _myField +1;
            return age + 1;
        }

        public static void MyStaticMethod()
        {
            _howManyBirthdaysCalled = _howManyBirthdaysCalled + 1;
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


## Homework
Create a class that keeps track of how many times its been called
