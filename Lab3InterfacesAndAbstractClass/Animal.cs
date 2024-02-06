using System;

namespace Lab3InterfacesAndAbstractClass
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public int Age { get; set; }
        protected Animal(string name)
        {
            Name = name;
        }
        public abstract void Eat();

        public void SetColour(string colour)
        {
            Colour = colour;
        }
        public void SetAge(int age)
        {
            Age = age;
        }
        public string GetName()
        {
            return Name;
        }

        public string GetColour()
        {
            return Colour;
        }

        public int GetAge()
        {
            return Age;
        }
    }
}
