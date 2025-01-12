namespace MaxNumOfVowelsInASubstrOfGivenLen
{
    internal class Program
    {
        private static readonly char[] VOWELS = new char[] { 'a', 'e', 'i', 'o', 'u' };

        public static int MaxVowels(string s, int k)
        {
            var maxVowelCount = 0;
            var currentVowelCount = 0;

            // first window
            for (var i = 0; i < k; i++)
            {
                if (IsVowel(s[i]))
                {
                    currentVowelCount++;
                }
            }
            maxVowelCount = currentVowelCount;

            // sliding window
            for (var i = k; i < s.Length; i++)
            {
                if (IsVowel(s[i - k]))
                {
                    currentVowelCount--;
                }

                if (IsVowel(s[i]))
                {
                    currentVowelCount++;
                }

                maxVowelCount = maxVowelCount >= currentVowelCount ? maxVowelCount : currentVowelCount;
            }

            return maxVowelCount;
        }

        private static bool IsVowel(char chr)
        {
            var result = false;
            foreach (var vowel in VOWELS)
            {
                if (chr == vowel)
                {
                    result = true;
                    break;
                }
            }

            return result;
        }
        static void Main(string[] args)
        {
            var firstCase = "abciiidef";
            var firstCaseK = 3;
            var result = MaxVowels(firstCase,firstCaseK);
            Console.WriteLine(result);
        }
    }
}
