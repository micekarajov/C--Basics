Console.WriteLine("Task 2 - Average Number");

Console.WriteLine("Please enter the first number: ");
bool isNumber1 = int.TryParse(Console.ReadLine(), out int num1);
Console.WriteLine("Please enter the second number: ");
bool isNumber2 = int.TryParse(Console.ReadLine(), out int num2);
Console.WriteLine("Please enter the third number: ");
bool isNumber3 = int.TryParse(Console.ReadLine(), out int num3);
Console.WriteLine("Please enter the fourth number: ");
bool isNumber4 = int.TryParse(Console.ReadLine(), out int num4);


if (isNumber1 && isNumber2 && isNumber3 && isNumber4)
{
    int average = (num1 + num2 + num3 + num4) / 4;
    Console.WriteLine($"The average of {num1} {num2} {num3} {num4} is: {average}");
} else
{
    Console.WriteLine("Please enter numbers!");
}
