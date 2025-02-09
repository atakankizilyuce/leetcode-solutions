namespace MaximumAverageSubarrayI
{
    internal class Program
    {

       // n == nums.length
       // 1 <= k <= n <= 105
       //-104 <= nums[i] <= 104

        public static double FindMaxAverage(int[] nums, int k)
        {
            var sum = 0d;
            for (var i = 0; i < k; i++)
            {
                sum += nums[i];
            }

            var maxSum = sum;
            for (var i = k; i < nums.Length; i++)
            {
                sum += nums[i] - nums[i - k];
                maxSum = maxSum >= sum ? maxSum : sum;
            }

            return maxSum / k;
        }

        static void Main(string[] args)
        {
            var firstCase = new int[] { 1, 12, -5, -6, 50, 3 };
            var firstCaseK = 4;
            var result = FindMaxAverage(firstCase, firstCaseK);
            Console.WriteLine(result);
        }
    }
}
