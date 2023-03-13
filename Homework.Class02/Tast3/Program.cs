Console.WriteLine("please enter the first number: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("please enter the second number: ");
int secondNumber = int.Parse(Console.ReadLine());

Console.WriteLine("The first number is " + firstNumber);
Console.WriteLine("The second number is " + secondNumber);

Console.WriteLine("After Swapping");
int newNum1 = firstNumber;
int newNum2 = secondNumber;
secondNumber = newNum1;
firstNumber = newNum2;
Console.WriteLine($"First number is {firstNumber}");
Console.WriteLine($"Second number is {secondNumber}");