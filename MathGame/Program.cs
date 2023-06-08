Console.WriteLine("Please type your name.");

var name = Console.ReadLine();
var date = DateTime.UtcNow;

Console.WriteLine("-----------------------------------------------");
Console.WriteLine($"Hello {name}. It's {date}. This is your math game, and it's also proof that you know the basics of C#. \n");
Console.WriteLine($@"What game would you like to play today? Choose from the options below:
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit the program");
Console.WriteLine("-----------------------------------------------");