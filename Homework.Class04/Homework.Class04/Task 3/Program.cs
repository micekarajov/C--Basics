// ----- Homework Class 04
Console.WriteLine("--- Task 03 ---");

Console.WriteLine("Please enter a number: ");
bool isNumber = int.TryParse(Console.ReadLine(), out int number);

int duplicateNumber = number;
int digitCount = 0;

while (duplicateNumber > 0)
{
    duplicateNumber = duplicateNumber / 10;
    digitCount++;
}

int[] digits = new int[digitCount];
duplicateNumber = number;

for (int i = 0; i < digitCount; i++)
{
    digits[i] = duplicateNumber % 10;
    duplicateNumber = duplicateNumber / 10;
}
Array.Reverse(digits);


int SumOfTheNumbers(int number) 
{
    int sum = 0;
    while (number != 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}

if (isNumber && number != 0)
{
    int sum = SumOfTheNumbers(number);
    Console.WriteLine($"The sum of the digits in the number {number}({string.Join(", ", digits)}) is: {sum}");
}
else
{
    Console.WriteLine("Please enter a number: ");
}
