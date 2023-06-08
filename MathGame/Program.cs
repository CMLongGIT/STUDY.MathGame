Console.WriteLine("Please type your name.");

var name = Console.ReadLine();
var date = DateTime.UtcNow;

Console.WriteLine("-----------------------------------------------");
Console.WriteLine($"Hello {name}. It's {date}. This is a simple collection of C# math games to learn fundamentals. \n");
Console.WriteLine($@"What game would you like to play today? Choose from the options below:
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit the program");
Console.WriteLine("-----------------------------------------------");

var gameSelected = Console.ReadLine();

if (gameSelected.Trim().ToLower() == "a")
{
    Console.WriteLine("Addition game selected.");
}
else if (gameSelected.Trim().ToLower() == "s")
{
    Console.WriteLine("Subtraction game selected.");
}
else if (gameSelected.Trim().ToLower() == "m")
{
    Console.WriteLine("Multiplication game selected.");
}
else if (gameSelected.Trim().ToLower() == "d")
{
    Console.WriteLine("Division game selected.");
}
else if (gameSelected.Trim().ToLower() == "q")
{
    Console.WriteLine("Goodbye");
    Environment.Exit(1);
}
else
{
    Console.WriteLine("Invalid Input.");
}