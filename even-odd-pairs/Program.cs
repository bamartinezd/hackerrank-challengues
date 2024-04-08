class Program { 
    public static void Main(String[] args)
    {
        Console.WriteLine(HasEvenOddPairs(new int[] { 1,2,3,4,5,7,8,10 }));
        Console.ReadLine();
    }

    public static bool HasEvenOddPairs(int[] nums) {
        
        if (nums.Length % 2 == 0)
        {
            int countOfEvens = nums.Count(x => x % 2 == 0);

            if (countOfEvens == nums.Length / 2)
                return true;
        }

        return false;
    }
}
