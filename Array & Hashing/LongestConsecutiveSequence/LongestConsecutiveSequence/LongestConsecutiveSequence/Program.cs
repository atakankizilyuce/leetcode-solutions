namespace LongestConsecutiveSequence
{
    internal class Program
    {
        public static int LongestConsecutive(int[] nums)
        {
            var counter = 0;
            if (nums.Length == 0)
            {
                return counter;
            }

            var numSet = new HashSet<int>(nums);
            foreach (var num in numSet)
            {
                if (!numSet.Contains(num - 1))
                {
                    var currentNum = num;
                    var currentStreak = 1;

                    while (numSet.Contains(currentNum + 1))
                    {
                        currentNum++;
                        currentStreak++;
                    }

                    if (currentStreak > counter)
                    {
                        counter = currentStreak;
                    }
                }
            }
            numSet.Clear();
            GC.Collect();

            return counter;
        }

        static void Main(string[] args)
        {
            var firstCase = new int[] { 100, 4, 200, 1, 3, 2 };
            var secondCase = new int[] { 9, 1, 4, 7, 3, -1, 0, 5, 8, -1, 6 };
            var result = LongestConsecutive(secondCase);
            Console.WriteLine(result);
        }
    }
}