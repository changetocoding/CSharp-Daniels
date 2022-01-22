using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAndInheritance
{
    class Bird : Animal
    {
        public override void WriteName()
        {
            Console.WriteLine("NEW METHOD");
        }
    }
}
