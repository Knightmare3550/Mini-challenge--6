Console.WriteLine("Hello, World!");
Console.WriteLine("ODD OR EVEN");
bool playAgain = true;
while (playAgain)
{
Console.Write("Enter a whole number: ");
string input = Console.ReadLine();
int number;
if (int.TryParse(input, out number))
{
if (number % 2 == 0)
{
Console.WriteLine($"{number} is EVEN!");
}
else
{
Console.WriteLine($"{number} is ODD!");
}
Console.Write("Play again? (yes/no): ");
string answer = Console.ReadLine().ToLower();
if (answer != "yes")
{
playAgain = false;
}
}
else
{
Console.WriteLine("Invalid input. Please enter a whole number.");
}
}
Console.WriteLine("Thanks for playing!");