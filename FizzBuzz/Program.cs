string welcomeText = "Welcome to Fizzbuzz!";
string constraintsText = "FizzBuzz requires the following (1 ≤ X < Y ≤ N ≤ 100)";
string inputText = "Please input according to pattern [X Y N]: ";
string userInput;

int X = 0, Y = 0, N = 0;

Console.WriteLine(welcomeText + "\n" + constraintsText);

bool userInputValid = false;

// Starting with input checks and sanitization
while (!userInputValid)
{
    // Visual preference to have a new line
    Console.WriteLine();

    Console.Write(inputText);
    userInput = Console.ReadLine();

    // Checking if input is empty
    if (string.IsNullOrWhiteSpace(userInput))
    {
        PrintColored("Error: Input can not be empty, try again", ConsoleColor.Red);
        continue;
    }

    // Spliting and cleaning input
    string[] parts = userInput.Split(' ', StringSplitOptions.RemoveEmptyEntries);

    // Checking if I have 3 entries, if each entry is a integer and if yes save value in correct var
    bool areThreeNumbers = parts.Length == 3 &&
                          int.TryParse(parts[0], out X) &&
                          int.TryParse(parts[1], out Y) &&
                          int.TryParse(parts[2], out N);

    // If any of areThreeNumbers checks are incorrect, generate a general error message
    if (!areThreeNumbers)
    {
        PrintColored("Error: Please enter exactly 3 whole numbers separated by spaces.", ConsoleColor.Red);
        PrintColored("Example: 3 5 20", ConsoleColor.Yellow);
        continue;
    }

    // Check constraints: 1 ≤ X < Y ≤ N ≤ 100
    if (!(1 <= X && X < Y && Y <= N && N <= 100))
    {
        PrintColored("Error: " + constraintsText, ConsoleColor.Red);
        continue;
    }



    PrintColored("\nEntered numbers are ok \nX: " + X + "\n" + "Y: " + Y + "\n" + "N: " + N,ConsoleColor.Green);
    PrintColored("Continuing with fizzing",ConsoleColor.Green);

    for (int i = 1; i <= N; i++)
    {
        PrintColored(i);
    }


    userInputValid = true;
}


static void PrintColored<T>(T message, ConsoleColor color = ConsoleColor.Gray)
{
    Console.ForegroundColor = color;
    Console.WriteLine(message);
    Console.ResetColor();
}