

// @todo do i need to declare any empty vars before use, how does c# handle this?
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
    // just a visually preference to have a new line
    // @todo - is there a better way?
    Console.WriteLine("");

    // @todo might not be necessary
    // if looped in and there is an error message show it
    // string errorMessage = string.Empty;

    Console.Write(inputText);
    userInput = Console.ReadLine();

    // checking if total value is empty
    if (string.IsNullOrWhiteSpace(userInput))
    {
        Console.WriteLine("Error: Input can not be empty, try again");
        continue;
    }

    // spliting and sanitizing the input
    string[] parts = userInput.Split(' ', StringSplitOptions.RemoveEmptyEntries);

    // checking if I have 3 entries, if each entry is a integer and if yes save value in correct var
    bool isThreeNumbers = parts.Length == 3 &&
                          int.TryParse(parts[0], out X) &&
                          int.TryParse(parts[1], out Y) &&
                          int.TryParse(parts[2], out N);

    // if any of above checks are incorrect, generate a general error message
    // instead of doing lots of different individual checks
    if (!isThreeNumbers)
    {
        Console.WriteLine("Error: Please enter exactly 3 whole numbers separated by spaces.");
        Console.WriteLine("Example: 3 5 20");
        continue;
    }

    Console.WriteLine("X: "+ X + "\n" + "Y: " + Y + "\n" + "N: " + N);

    userInputValid = true;
}
