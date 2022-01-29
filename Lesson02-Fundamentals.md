# Fundamentals - data structures (list, array, dicts)
Today we will cover the core of every programing language: Data types, control statements and looping. This is common to most programming languages

## Basics
1. OO language - basically means everything must be an object
2. Strongly typed 



## Data types
### 'Primtives'
- String
- int, double, decimal, 
- boolean

### Data structures
-Array: Collection of objects. Must be all same type. Cant change size once created
```cs
var items = new string[] {"Hello", "World", "People"};
```
-List: Array but can add more items
```cs
var myList = new List<string>();
myList.Add("Hello");
myList.Add("World");
myList.Add("People");
// Equivalent to 
var myOtherList = new List<string>() { "Hello", "World", "People" };
```

```
// set value for list/array 
myList[0] = "Replace Hello with this";
// get value 
myList[0];
```
-Dict - Key to value mapping


## Control statements
### If statement
```cs
  var shouldPrint = false;
  var myList = new List<string>() { "Hello", "World", "People" };
  if (shouldPrint)
  {
      Console.WriteLine("We should print");
  }
  else if (myList.Count == 3)
  {
      Console.WriteLine("The count of myList is 3");
  }
  else
  {
      Console.WriteLine("This gets called if the other 2 statements are false");
  }
```

### For loops
```cs
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("We are on count " + i);
}
```

### Foreach
```cs
var items = new string[] {"Hello", "World", "People"};
foreach (var item in items)
{
    Console.WriteLine(item);
}
```


## Objects Orientate languages 101:
abstraction - cell phone/car: interact with few buttons but stuff under hood is hiden from u.
encapsulation - privacy: dont want boss to know gone on holiday. But simple as bank balance. ETP: Client is basically one big encapsulation of data so interact through ui. Imagine anyone just writing to db
inheritance - Parent. Children inherit it
polymorphism - https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/polymorphism. virtual methods. subclass implements in own way.

Overriding vs overloading - will cover later

### S O L I D


# Homework: Fizz Buzz
### The Task:
Create a console application that counts from 1 to a number the user specifies. 
For each number output "This is X out of Y", where X is the current number, and Y is the number the user specified above.
Any number divisible by three should be replaced by the word "fizz" instead.
Any number divisible by five should be replaced by the word "buzz" instead. 
Numbers divisible by 3 and 5 should be replaced by the word "fizz buzz".

### Sample output:
> This is 1 out of 100  
> This is 2 out of 100  
> Fizz  
> This is 4 out of 100  
> Buzz  
> Fizz  
> This is 7 out of 100  
> ...  




