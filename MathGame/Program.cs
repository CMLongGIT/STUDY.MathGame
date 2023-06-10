using static System.Formats.Asn1.AsnWriter;

var date = DateTime.UtcNow;

var games = new List<string>();

string name = GetName();

Menu(name);

void Menu(string name)
{
    Console.WriteLine("-----------------------------------------------");
    Console.WriteLine($"Hello {name}. It's {date}. This is a simple collection of C# math games to learn fundamentals. \n");

    bool isGameOn = true;

    do
    {
        Console.Clear();

        Console.WriteLine($@"What game would you like to play today? Choose from the options below:
V - View Previous Games
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit the program");
        Console.WriteLine("-----------------------------------------------");

        var gameSelected = Console.ReadLine();

        switch (gameSelected.Trim().ToLower())
        {
            case "v":
                GetGames();
                break;
            case "a":
                AdditionGame("Addition game selected.");
                break;
            case "s":
                SubtractionGame("Subtraction game selected.");
                break;
            case "m":
                MultiplicationGame("Multiplication game selected.");
                break;
            case "d":
                DivisionGame("Division game selected.");
                break;
            case "q":
                Console.WriteLine("Goodbye");
                isGameOn = false;
                break;
            default:
                Console.WriteLine("Invalid Input.");
                break;
        }
    } while (isGameOn);

    
}

void GetGames()
{
    Console.Clear();
    Console.WriteLine("Games History");
    Console.WriteLine("----------------------------");
    foreach(var game in games)
    {
        Console.WriteLine(game);
    }
    Console.WriteLine("----------------------------\n");
    Console.WriteLine("Press any key to return to the Main Menu");
    Console.ReadLine();
}

string GetName()
{
    Console.WriteLine("Please type your name.");
    var name = Console.ReadLine();
    return name;
}

void AdditionGame(string message)
{
    Console.WriteLine(message);

    var random = new Random();
    var score = 0;

    int firstNumber;
    int secondNumber;

    for(int i = 0; i < 5; i++)
    {
        Console.Clear();
        Console.WriteLine(message);
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} + {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber + secondNumber)
        {
            Console.WriteLine("Your answer was correct! Type any key for the next question");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Your answer was incorrect. Type any key for the next question");
            Console.ReadLine();
        }

        if (i == 4)
        {
            Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu.");
            Console.ReadLine();
        }
    }

    AddToHistory(score, "Addition");
}

void SubtractionGame(string message)
{
    Console.WriteLine(message);

    var random = new Random();
    var score = 0;

    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++)
    {
        Console.Clear();
        Console.WriteLine(message);
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} - {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber - secondNumber)
        {
            Console.WriteLine("Your answer was correct! Type any key for the next question");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Your answer was incorrect. Type any key for the next question");
            Console.ReadLine();
        }

        if (i == 4)
        {
            Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu.");
            Console.ReadLine();
        }
    }

    AddToHistory(score, "Subtraction");
}

void MultiplicationGame(string message)
{
    Console.WriteLine(message);

    var random = new Random();
    var score = 0;

    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++)
    {
        Console.Clear();
        Console.WriteLine(message);
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} * {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber * secondNumber)
        {
            Console.WriteLine("Your answer was correct! Type any key for the next question");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Your answer was incorrect. Type any key for the next question");
            Console.ReadLine();
        }

        if (i == 4)
        {
            Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu.");
            Console.ReadLine();
        }
    }

    AddToHistory(score, "Multiplication");
}

void DivisionGame(string message)
{
    var score = 0;

    for (int i = 0; i < 5; i++)
    {
        Console.Clear();
        Console.WriteLine(message);
        var divisionNumbers = GetDivisionNumbers();
        var firstNumber = divisionNumbers[0];
        var secondNumber = divisionNumbers[1];

        Console.WriteLine($"{firstNumber} / {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber / secondNumber)
        {
            Console.WriteLine("Your answer was correct! Type any key for the next question");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Your answer was incorrect. Type any key for the next question");
            Console.ReadLine();
        }

        if (i == 4)
        {
            Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu.");
            Console.ReadLine();
        }
    }

    AddToHistory(score, "Division");
}

int[] GetDivisionNumbers()
{
    var random = new Random();
    var firstNumber = random.Next(1, 99);
    var secondNumber = random.Next(1, 99);

    var result = new int[2];


    while (firstNumber % secondNumber != 0)
    {
        firstNumber = random.Next(1, 99);
        secondNumber = random.Next(1, 99);
    }

    result[0] = firstNumber;
    result[1] = secondNumber;

    return result;
}

void AddToHistory(int gameScore, string gameType)
{
    games.Add($"{DateTime.Now} - {gameType}: Score = {gameScore} pts");
}