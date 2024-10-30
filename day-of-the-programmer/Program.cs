using System;

class Program
{
    static void Main(string[] args)
    {

        int InputYear = int.Parse(Console.ReadLine());
        Console.WriteLine(dayOfProgrammer(InputYear));

    }

    public static string dayOfProgrammer(int year)
    {
        string result = string.Empty;

        if (year % 4 == 0)
        {
            if (year % 100 != 0)
            {
                result += "Gregorian's calendar leap year.";
            }
            
            result += "Julian's calendar leap year.";
        }
        else if (year % 400 != 0)
        {
            result += "Gregorian's calendar leap year.";
        }
        else
        {
            result += "Julian's calendar not a leap year.";
        }

        return result;
    }
}