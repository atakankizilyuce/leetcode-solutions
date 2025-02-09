namespace GetConcatenation
{
    internal class Program
    {
        public static int[] GetConcatenation(int[] nums)
        {
            var ans = new int[nums.Length * 2];
            for (var i = 0; i < nums.Length; i++)
            {
                ans[i] = nums[i];
                ans[i + nums.Length] = nums[i];
            }

            return ans;
        }

        static void Main(string[] args)
        {
            var firstCase = new int[] { 1, 2, 1 };
            var result = GetConcatenation(firstCase);
        }
    }
}
