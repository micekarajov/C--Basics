// ------- Homework Class 3 - Loops and Arrays-------
Console.WriteLine("----- Homewokr Class 3 - Task 1");

int[] numbersArray = new int[6];

int sumOfEven = 0;

for (int i = 0; i < numbersArray.Length; i++)
{
    Console.WriteLine($"Please enter random number no.{i + 1}");
    bool isNumber = int.TryParse(Console.ReadLine(), out int randomNumber);

    if (isNumber)
    {
        numbersArray[i] = randomNumber;
    }
    else
    {
        Console.WriteLine("Please enter a number!"); // koga ke vnesam pogresen input me nosi na slednoto iteriranje, kako da me vrati na istoto
        // primer vnesi random broj 1: i vnesnuvame gresen input i naredno ne nosi na vnesi random broj 2...
    }
}

foreach (int number in numbersArray)
{
    if (number % 2 == 0)
    {
        sumOfEven += number;
    }
}

Console.WriteLine($"The sum of the even numbers from the array is {sumOfEven}");