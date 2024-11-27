using System;

class Program
{
    static void Main(string[] args)
    {

        int InputYear = int.Parse(Console.ReadLine());
        Console.WriteLine(DayOfProgrammer(InputYear));

    }

    public static string DayOfProgrammer(int year)
    {
        string result = string.Empty;

        if (year % 4 == 0)
        {
            result += "Julian's calendar leap year: Every year that is exactly divisible by four is a leap year \n";
            if (year % 400 == 0)
            {
                result += "Gregorian's calendar leap year: Centurial years are leap years if they are exactly divisible by 400";
            }
            else if (year % 100 != 0)
            {
                result += "Gregorian's calendar leap year: Divisible by 4 and not divisible by 100";
            }
            else
            {
                result += "Gregorian's calendar: NOT a leap year.";    
            }
        }
        else
        {
            result += "Julian's calendar: NOT a leap year.";
        }

        //Now get the number of the day based on the provided year

        DateTime dateTime = new(year, 9, 13);
        Console.WriteLine($"{dateTime}");

        return $"{result} ";
    }
}