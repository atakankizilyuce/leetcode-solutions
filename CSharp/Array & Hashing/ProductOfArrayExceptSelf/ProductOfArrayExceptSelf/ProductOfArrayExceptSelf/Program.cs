namespace ProductOfArrayExceptSelf
{
    internal class Program
    {
        public static int[] ProductExceptSelf(int[] nums)
        {
            var result = new int[nums.Length];

            if (nums.Length == 0)
            {
                return result;
            }

            var temp = 1;
            for (var i = 0; i < nums.Length; i++)
            {
                result[i] = temp;
                temp *= nums[i];
            }

            temp = 1;
            for (var i = nums.Length - 1; i >= 0; i--)
            {
                result[i] *= temp;
                temp *= nums[i];
            }

            return result;
        }


        static void Main(string[] args)
        {
            var firstCase = new int[] { 1, 2, 3, 4 };
            var result = ProductExceptSelf(firstCase);
            Console.WriteLine(result);
        }
    }
}
