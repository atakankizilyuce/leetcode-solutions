namespace TopKFrequentElements
{
    internal class Program
    {
        public static int[] TopKFrequent(int[] nums, int k)
        {
            var freqMap = new Dictionary<int, int>();
            foreach (int num in nums)
            {
                if (!freqMap.ContainsKey(num))
                {
                    freqMap.Add(num, 0);
                }
                freqMap[num]++;
            }

            var frequencyList = new List<KeyValuePair<int, int>>(freqMap);
            frequencyList.Sort((a, b) => b.Value.CompareTo(a.Value));

            var result = new int[k];
            for (var i = 0; i < k; i++)
            {
                result[i] = frequencyList[i].Key;
            }

            return result;
        }

        static void Main(string[] args)
        {
            var firstCase = new int[] { 1, 1, 1, 2, 2, 3 };
            var firstCaseK = 2;

            var result = TopKFrequent(firstCase, firstCaseK);
            Console.WriteLine(result);
        }
    }
}
