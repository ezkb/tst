// FizzBuzz 

string welcomeMsg = "Welcome to Fizzbuzz!";
string constraintsInfo = "FizzBuzz requires the following constraints: (1 ≤ X < Y ≤ N ≤ 100)";
string inputInfo = "Please input according to pattern X Y N: ";

Console.WriteLine(welcomeMsg + "\n" + constraintsInfo);
Console.Write(inputInfo);

string[] userInput = Console.ReadLine().Split();

Console.WriteLine(userInput[0] + "_" + userInput[1] + "_" + userInput[2]);