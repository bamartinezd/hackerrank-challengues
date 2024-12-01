using Newtonsoft.Json;
using System;
using System.Linq;
using System.Text.Json.Serialization;

class Program
{

    /*
     * Complete the 'climbingLeaderboard' function below.
     * https://www.hackerrank.com/challenges/climbing-the-leaderboard
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY ranked
     *  2. INTEGER_ARRAY player
     */

    public static List<int> ClimbingLeaderboard(List<int> ranked, List<int> player)
    {
        var positionByGame = new List<int>();
        
        //Get the position of the player by game based on ranked
        foreach (var scoreByGame in player)
        {
            ranked.Add(scoreByGame);
            
            List<int> rankedOrdered = ranked.OrderDescending().ToList();
            Console.WriteLine(JsonConvert.SerializeObject(rankedOrdered));

            Console.WriteLine(JsonConvert.SerializeObject(rankedOrdered.Distinct()));

            positionByGame.Add(rankedOrdered.IndexOf(scoreByGame)+1);
            ranked.Remove(scoreByGame);

            
        }

        return positionByGame;
    }

    public static void Main(string[] args)
    {
        List<int> result = ClimbingLeaderboard([100, 90, 90, 80], [70, 80, 105]);
        Console.WriteLine(JsonConvert.SerializeObject(result));
    }
}
