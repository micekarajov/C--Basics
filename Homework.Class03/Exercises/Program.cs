Console.WriteLine("Exercise 4 - Arrays");


string[] wordsArray = new string[] { "SEDC", "G5", "Html & Css", "JavaScript", "C#" };
double[] decimalArray = new double[] { 1.55, 2.55, 3.55, 4.55, 5.55 };
char[] keyboardArray = new char[] { 'a', 'b', 'c', 'd', 'e' };
bool[] trueFalseArray = new bool[] { false, true, true, false, true };
int[][] twoDimensionalArray = new int[][]
{
    new int [] { 1, 2},
    new int [] { 3, 4 },
    new int [] { 5, 6 },
    new int [] { 7, 8 },
    new int [] { 9, 10 }
};


Console.WriteLine("Exercise 5 - Arrays");

int[] newArray = new int[5];

for (int i = 0; i < newArray.Length; i++)
{
    Console.WriteLine($"Please enter a number for element {i + 1}: ");
    bool isNUmber1 = int.TryParse(Console.ReadLine(), out int inputNumber);

    if (isNUmber1)
    {
        newArray[i] = inputNumber;
    }
    else
    {
        Console.WriteLine("Please enter a number");
    }
}

int sum = 0;
foreach (int array in newArray)
{
    sum += array;
}

Console.WriteLine($"The sum of all elements in the array is: {sum}");



Console.WriteLine("Exercise 6 - Arrays");

string[] names = new string[0];

while (true)
{
    Console.Write("Enter a name: ");
    string name = Console.ReadLine();

    Array.Resize(ref names, names.Length + 1);
    names[names.Length - 1] = name;

    Console.WriteLine("Do you want to enter another name? Y/N");
    string answer = Console.ReadLine();

    if (answer.ToUpper() == "N") 
    {
        break;
    }
}

Console.WriteLine("This is all entered names:");
for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine($"{i + 1}. {names[i]}");

}