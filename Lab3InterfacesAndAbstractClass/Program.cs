using Lab3InterfacesAndAbstractClass;
using System;


namespace Lab3InterfacesAndAbstractClass
{
    class ProgramMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter dog's name:");
            string dogName = Console.ReadLine();
            Dog dog = new Dog(dogName);
            Console.WriteLine($"Enter dog's colour:");
            string dogColour = Console.ReadLine();
            dog.SetColour(dogColour);
            Console.WriteLine($"Enter dog's age:");
            int dogAge = int.Parse(Console.ReadLine());
            dog.SetAge(dogAge);
            Console.WriteLine($"Dog: {dog.GetName()}, Colour: {dog.GetColour()}, Age: {dog.GetAge()}");
            dog.Eat();

            Console.WriteLine("\nEnter cat's name:");
            string catName = Console.ReadLine();
            Cat cat = new Cat(catName);
            Console.WriteLine($"Enter cat's colour:");
            string catColour = Console.ReadLine();
            cat.SetColour(catColour);
            Console.WriteLine($"Enter cat's age:");
            int catAge = int.Parse(Console.ReadLine());
            cat.SetAge(catAge);
            Console.WriteLine($"Cat: {cat.GetName()}, Colour: {cat.GetColour()}, Age: {cat.GetAge()}");
            cat.Eat();
        }
    }
}

    