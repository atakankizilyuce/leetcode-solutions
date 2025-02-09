namespace MaxNumberOfKSumPairs
{
    internal class Program
    {
        public static int MaxOperations(int[] nums, int k)
        {
            var operations = 0;
            var numberCountMap = new Dictionary<int, int>();
            for (var i = 0; i < nums.Length; i++)
            {
                var wantedNumber = k - nums[i];
                if (numberCountMap.ContainsKey(wantedNumber) && numberCountMap[wantedNumber] > 0)
                {
                    operations++;
                    numberCountMap[wantedNumber]--;
                }
                else
                {
                    if (!numberCountMap.ContainsKey(nums[i]))
                    {
                        numberCountMap[nums[i]] = 0;
                    }
                    numberCountMap[nums[i]]++;
                }
            }

            return operations;
        }

        static void Main(string[] args)
        {
            var firstCase = new int[] { 1, 2, 3, 4 };
            var firstCaseK = 5;
            var result = MaxOperations(firstCase, firstCaseK);
            Console.WriteLine(result);
        }
    }
}
