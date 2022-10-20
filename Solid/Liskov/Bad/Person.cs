using System;

namespace Liskov
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class InvalidAgeException : Exception
    {
        public override string ToString()
        {
            return "invalid age";
        }
    }
}