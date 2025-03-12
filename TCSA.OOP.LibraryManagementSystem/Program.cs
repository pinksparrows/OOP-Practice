namespace TCSA.OOP.LibraryManagementSystem;

class Program
{
    static void Main(string[] args)
    {
        //UserInterface.MainMenu();

        Car car1 = new Car();
        Car car2 = new Car();

        car1.name = "Ferrari";
        car2.name = "BMW";
        
        car1.PrintName();
        car2.PrintName();
    }
}

class Car()
{
    internal string name;
    
    internal void PrintName()
    {
        Console.WriteLine($"I'm a {name}");
    }
}