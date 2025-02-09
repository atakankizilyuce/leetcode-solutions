namespace TwoSum
{
    internal class Program
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            var result = new int[2];
            if (nums == null || nums.Length == 0)
            {
                return result;
            }

            for (var i = 0; i < nums.Length; i++)
            {
                var firstNumber = nums[i];
                for (var j = i + 1; j < nums.Length; j++)
                {
                    var secondNumber = nums[j];
                    if (firstNumber + secondNumber == target)
                    {
                        result[0] = i;
                        result[1] = j;
                    }
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            int[] firstCase = [2, 7, 11, 15];
            var firstTarget = 9;

            var result = TwoSum(firstCase, firstTarget);
            Console.WriteLine(result);
        }
    }
}
