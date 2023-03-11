Console.WriteLine("----- Homewokr Class 3 - Task 2");

string[] studentsG1 = new string[] { "Mitko Majorot", "Dimitar", "Eleonora", "Tode", "Nikola" };
string[] studentsG2 = new string[] { "Zdravko", "Petko", "Janko", "Branko", "Trajko", "Stanko" };

Console.WriteLine("Please enter a number(between 1 and 2): ");
bool isNumber = int.TryParse(Console.ReadLine(), out int number);

if (isNumber)
{
    if (number == 1)
    {
        Console.WriteLine("The students in G1 are:");
        foreach (string students in studentsG1)
        {
            Console.WriteLine(students);
        }
    }
    else if (number == 2)
    {
        Console.WriteLine("The students in G2 are:");
        foreach (string students in studentsG2)
        {
            Console.WriteLine(students);
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a number between 1 and 2");
    }
}
else
{
    Console.WriteLine("Please enter a number!");
}