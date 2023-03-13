// ----- Homework Class 04
Console.WriteLine("--- Task 02 ---");

Console.WriteLine("Please enter a sentence: ");
string sentence = Console.ReadLine();

string[] splitString = sentence.Split(' ');


if (splitString.Length <= 1 )
{
    Console.WriteLine("Please enter a sentence!");
}
else
{
    foreach (string array in splitString)
    {
        Console.WriteLine(array);
    }
}
