using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAndInheritance
{
    class Animal
    {
        public int Age;
        public string FirstName = "first name ";
        public string SecondName = "second name ";
        public int AmountOfLegs;
        public Animal()
        {

        }
        public Animal(int newAge)
        {
            Age = newAge;
        }
        public virtual void WriteName()
        {
            var thirdName = "name";
            Console.WriteLine(FirstName + SecondName + thirdName);
        }
    }
}
