// FizzBuzz 

string welcomeMsg = "Welcome to Fizzbuzz!";
string constraintsInfo = "FizzBuzz requires the following constraints: (1 ≤ X < Y ≤ N ≤ 100)";
string inputInfo = "Please input according to pattern X Y N: ";

int X = 0, Y = 0, N = 0;

bool userInputValid = false;

Console.WriteLine(welcomeMsg + "\n" + constraintsInfo);

while (!userInputValid)
{
    // if looped in and there is an error message show it, if empty it is the first time? 
    string errorMessage = string.Empty;

    Console.Write(inputInfo);
    string[] userInput = Console.ReadLine().Split();

    X = int.Parse(userInput[0]);
    Y = int.Parse(userInput[1]);
    N = int.Parse(userInput[2]);

    Console.WriteLine(X + " " + Y + " " + N);
}