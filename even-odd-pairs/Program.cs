class Program { 
    public static void Main(String[] args)
    {
        Console.WriteLine(HasEvenOddPairs(new int[] { 1,2,3,4,5,7 }));
        Console.ReadLine();
    }

    public static bool HasEvenOddPairs(int[] nums) {
        
        if (nums.Count() % 2 == 0)
        {
            int numOfEvens = 0;

            foreach (var even in nums)
            {

                if (even % 2 == 0)
                {
                    numOfEvens++;    
                }

            }

            if (numOfEvens == nums.Count()/2)
            {
                return true;
            }
        }

        return false;
    }
}
