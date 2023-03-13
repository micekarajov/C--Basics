// ----- Homework Class 04
Console.WriteLine("--- Task 03 ---");

Console.WriteLine("Please enter your birthday yyyy/mm/dd");
DateTime birthDate = Convert.ToDateTime(Console.ReadLine());

int AgeCalculator(DateTime birthdate)
{
    DateTime today = DateTime.Now;
    int years = new DateTime(DateTime.Now.Subtract(birthdate).Ticks).Year - 1;
    return years;
    //DateTime pastDate = birthdate.AddYears(years);

    //int Months = 0;
    //for (int i = 1; i <= 12; i++)
    //{
    //    if (pastDate.AddMonths(i) == today)
    //    {
    //        Months = i;
    //        break;
    //    }
    //    else if (pastDate.AddMonths(i) >= today)
    //    {
    //        Months = i - 1;
    //        break;
    //    }
    //}
    //int Days = today.Subtract(pastDate.AddMonths(Months)).Days;
    //int Hours = today.Subtract(pastDate).Hours;
    //int Minutes = today.Subtract(pastDate).Minutes;
    //int Seconds = today.Subtract(pastDate).Seconds;
    //return String.Format("Age: {0} Year(s) {1} Month(s) {2} Day(s) {3} Hour(s) {4} Second(s)",years, Months, Days, Hours, Seconds);
}


int age = AgeCalculator(birthDate);
//Console.WriteLine(age);
Console.WriteLine($"Your are {age} years old.");