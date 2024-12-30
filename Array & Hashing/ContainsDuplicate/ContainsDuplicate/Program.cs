namespace ContainsDuplicate
{
    internal class Program
    {
        public static bool ContainsDuplicate(int[] nums)
        {
            var map = new HashSet<int>();

            for (var i = 0; i < nums.Count(); i++)
            {
                if (!map.Add(nums[i]))
                {
                    return true;
                }
            }
            return false;
        }

        static void Main(string[] args)
        {
            int[] firstTest = { 1, 2, 3, 4 }; // false
            //int[] secondTest = { 1, 2, 3, 2 }; // true
            var result = ContainsDuplicate(firstTest);
            Console.WriteLine(result);
        }
    }
}
