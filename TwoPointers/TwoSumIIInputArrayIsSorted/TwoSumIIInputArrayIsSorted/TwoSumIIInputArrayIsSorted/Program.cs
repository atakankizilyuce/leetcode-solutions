namespace TwoSumIIInputArrayIsSorted
{
    internal class Program
    {
        public static int[] TwoSum(int[] numbers, int target)
        {
            var left = 0;
            var right = numbers.Length - 1;
            while (left < right)
            {
                var curSum = numbers[left] + numbers[right];
                if (curSum > target)
                {
                    right--;
                }
                else if (curSum < target)
                {
                    left++;
                }
                else
                {
                    return new int[] { left + 1, right + 1 };
                }
            }
            return new int[0];
        }

        static void Main(string[] args)
        {
            var firstCase = new int[] { 2, 7, 11, 15 };
            var firstCaseTarget = 9;
            var result = TwoSum(firstCase,firstCaseTarget);
            Console.WriteLine(result);
        }
    }
}
