using Newtonsoft.Json;
using System.Linq;

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

            var rankedOrdered = ranked.OrderDescending();
            var distinct = rankedOrdered.Distinct().ToList();
            positionByGame.Add(distinct.IndexOf(scoreByGame) + 1);

            ranked.Remove(scoreByGame);
        }

        return positionByGame;
    }

    public static void Main(string[] args)
    {
        var result = ClimbingLeaderboard([100, 90, 90, 80], [70, 80, 105]);
        //var result = ClimbingLeaderboard([100, 100, 50, 40, 40, 20, 10], [5, 25, 50, 120]);
        Console.WriteLine(JsonConvert.SerializeObject(result));
    }
}
