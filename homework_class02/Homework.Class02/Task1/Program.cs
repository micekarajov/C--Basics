using System.Diagnostics.CodeAnalysis;
Console.WriteLine("Task 1 - Real Calculator");

Console.WriteLine("Please enter the first number: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter the second number: ");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter the operator ( +, - , * , / )");
string operator1 = Console.ReadLine();

if (operator1 == "+")
{
    int sum = number1 + number2;
    Console.WriteLine($"The result is {sum}");
} 
else if ( operator1 == "-")
{
    int sub = number1 - number2;
    Console.WriteLine($"The result is {sub}");
} 
else if ( operator1 == "*")
{
    int mult = number1 * number2;
    Console.WriteLine($"The result is {mult}");
} 
else if ( operator1 == "/") 
{
    int div = number1 / number2;
    Console.WriteLine($"The result is {div}");
} else
{
    Console.WriteLine("Please enter the right operator!");
}