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
```cs
string str = "string";
int value = 10; // integer/whole numbers
bool test = true; // false
double number = 0.1; // decimal points. Can add a d at end (1.1d) but not necessary. 64 bits
float floatingPointNo = 0.1f; // notice f at end- 32 bits smaller
decimal theDecimal = 0.1m; // notice m at end. Base 10 system so more accurate for financials
```

### Data structures
- Array: Collection of objects. Must be all same type. Cant change size once created
```cs
var items = new string[] {"Hello", "World", "People"};
```
- List: Array but can add more items
```cs
var myList = new List<string>();
myList.Add("Hello");
myList.Add("World");
myList.Add("People");
// Equivalent to 
var myOtherList = new List<string>() { "Hello", "World", "People" };
```

```cs
// set value for list/array 
myList[0] = "Replace Hello with this";
// get value 
myList[0];
```
- Dictionary - Key to value mapping
```cs
var dictionary = new Dictionary<string, string>();
dictionary.Add("David", "Nigeria");
dictionary.Add("Tom", "England");
dictionary.Add("Jin", "China");
Console.WriteLine(dictionary["David"]); // Nigeria
```


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


# Homework: Fizz Buzz
### The Task:
Create a console application that counts from 1 to a number the user specifies.  
For each number output "This is X out of Y", where X is the current number, and Y is the number the user specified above.   
Any number divisible by three should be replaced by the word "fizz" instead.  
Any number divisible by five should be replaced by the word "buzz" instead.   
Numbers divisible by 3 and 5 should be replaced by the word "fizz buzz".  

The modulus (remainder) operator in c# is this
```cs
10 % 5
```

### Sample output:
> This is 1 out of 100  
> This is 2 out of 100  
> Fizz  
> This is 4 out of 100  
> Buzz  
> Fizz  
> This is 7 out of 100  
> ...  




