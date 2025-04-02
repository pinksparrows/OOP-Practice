namespace TCSA.OOP.LibraryManagementSystem;

class Program
{
    void Main(string[] args)
    {
        //UserInterface userInterface = new();
        //userInterface.MainMenu();

        (string Title, int Pages) book1 = ("Frankenstein", 350);
        Console.WriteLine($"Title: {book1.Title}, Pages: {book1.Pages}");
    }
}