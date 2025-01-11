using System;

class Program
{
    /*
     https://coderbyte.com/editor/Coin%20Determiner:Csharp
     https://gist.github.com/barreyro/a0c0f67729e54b2fac05#file-coin-determiner
     */


    public static int CoinDeterminer(int num)
    {

        if (num < 5)
        {
            return num;
        }

        var coinsNumber = num / 11;

        if (coinsNumber % 11 == 0)
        {
            return coinsNumber + 2;
        }
        else
        {
            return coinsNumber + 1;
        }
    }

    static void Main()
    {
        Init();
    }

    static void Init()
    {
        Console.WriteLine("Please type the value, and I can show you how much coins of 1, 5, 7, 9, and 11 do you need.");
        Console.WriteLine(CoinDeterminer(int.Parse(Console.ReadLine())));
        Console.WriteLine("Once again?. Press Y or y");
        var cont = Console.ReadLine();
        if(cont == "Y" || cont == "y")
            Init();
    }

}