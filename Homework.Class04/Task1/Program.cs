// ----- Homework Class 04
Console.WriteLine("--- Task 01 ---");

Console.WriteLine("Please enter random word");
string inputWord = Console.ReadLine();

if (int.TryParse(inputWord, out int result1) || double.TryParse(inputWord, out double result2) && inputWord.Length > 5)
    {
    Console.WriteLine("Please insert a correct word with more than 5 characters");
} 
else
{
    string lastFiveChars = inputWord.Substring(inputWord.Length - 5);
    Console.WriteLine($"The last 5 characters from the inputed word is {lastFiveChars}");
}
