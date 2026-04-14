// FizzBuzz 

string welcomeText = "Welcome to Fizzbuzz!";
string constraintsText = "FizzBuzz requires the following (1 ≤ X < Y ≤ N ≤ 100)";
string inputText = "Please input according to pattern X Y N: ";
string userInput;

int X = 0, Y = 0, N = 0;

Console.WriteLine(welcomeText + "\n" + constraintsText);

bool userInputValid = false;

while (!userInputValid)
{
    Console.WriteLine("");
    // if looped in and there is an error message show it
    string errorMessage = string.Empty;

    Console.Write(inputText);
    userInput = Console.ReadLine();

    // checking if total value is empty
    if (string.IsNullOrWhiteSpace(userInput))
    {
        Console.WriteLine("Input can not be empty, try again");
        continue;
    }

    string[] parts = userInput.Split();

    // checking if all 3 parts are there
    if (parts.Length != 3 )
    {
        Console.WriteLine("Input 3 numbers exactly, try again");
        continue;
    }

    X = int.Parse(parts[0]);
    Y = int.Parse(parts[1]);
    N = int.Parse(parts[2]);

    Console.WriteLine(X + " " + Y + " " + N);

    userInputValid = true;
}
