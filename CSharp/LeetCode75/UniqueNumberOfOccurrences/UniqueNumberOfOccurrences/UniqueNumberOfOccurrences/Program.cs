namespace UniqueNumberOfOccurrences
{
    internal class Program
    {
        public static bool UniqueOccurrences(int[] arr)
        {
            var result = true;

            var numberFrequencies = new Dictionary<int, int>();
            foreach (var num in arr)
            {
                var numberFreq = 1;
                if (numberFrequencies.ContainsKey(num))
                {
                    numberFreq = numberFrequencies[num] + 1;
                }
                numberFrequencies[num] = numberFreq;
            }

            var index = 0;
            var frequencyMap = new int[numberFrequencies.Values.Count];
            foreach (var numberFrequency in numberFrequencies)
            {
                if (frequencyMap.Contains(numberFrequency.Value))
                {
                    result = false;
                    break;
                }
                else
                {
                    frequencyMap[index++] = numberFrequency.Value;
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            var firstCase = new int[] { 1, 2, 2, 1, 1, 3 };
            var result = UniqueOccurrences(firstCase);
            Console.WriteLine(result);
        }
    }
}
