namespace RemovingStarsFromAString
{
    internal class Program
    {
        public static string RemoveStars(string s)
        {
            var result = new char[s.Length];
            var pos = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '*')
                {
                    if (pos > 0)
                    {
                        pos--;
                    }
                }
                else
                {
                    result[pos] = s[i];
                    pos++;
                }
            }

            return new string(result, 0, pos);
        }
        static void Main(string[] args)
        {
            var firstCase = "leet**cod*e";
            var result = RemoveStars(firstCase);
            Console.WriteLine(result);
        }
    }
}
