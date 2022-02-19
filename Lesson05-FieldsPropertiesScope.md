###




# Class code

```cs
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();

            //set
            person.Name = "Jacob";
            person.Age = 25;


            //get
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);

        }
    }

    public class Person
    {
        //Field
        private string _name;

        //Property
        public int Age { get; set; }

        //Property
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        //Scope

        public int Birthday()
        {
            //declared & accessible only within the method
            var ageIncrease = 1;

            //Age (or _name) is accessible anywhere withinin the class
            Age = Age + ageIncrease;

            return Age;
        }

        public int Birthday(int years)
        {
            //parameter given in method, accessible only within method
            Age = Age + years;
            return Age;
        }
    }
```

# Homework

Phonebook part I:  
You've been tasked to design the phone book on a phone. 
The only problem is it on one of those old Nokia brick phones. So there is **some** limitations on the storage.


You should create a command line phone book application that must:
1. Have an option to add a name and an *11* digit number. The number may begin with a 0.
```
STORE david 07900001234
OK
STORE work 02080000110
OK
STORE peter 12345678901
OK
```
2. Have an option to retrieve a number given a name
```
GET peter
OK 12345678901
```
3. Have an option to delete/remove a name. It must return the number of the deleted person to confirm the deletion was successful
```
DEL peter
OK 12345678901
```
4. Have an option to Update the number for a person. Returns the previous number to confirm the update was successful  
```
UPDATE david 07700000000
OK last no was - 07900001234
```

5. You are only allowed to store the telephone number as a long as a string would be too big  

These restrictions might cause a name/number pair to accidentally override another but this is acceptable  
