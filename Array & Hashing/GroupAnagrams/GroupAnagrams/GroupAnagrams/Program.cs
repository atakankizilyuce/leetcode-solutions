namespace GroupAnagrams
{
    internal class Program
    {
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var result = new List<IList<string>>();
            if (strs.Length == 0 || strs == null)
            {
                return result;
            }

            var mapper = new Dictionary<string, IList<string>>();
            foreach (var str in strs)
            {
                var ch = str.ToCharArray();
                Array.Sort(ch);
                var chKey = new string(ch);

                if (!mapper.ContainsKey(chKey))
                {
                    mapper.Add(chKey, new List<string>());
                }
                mapper[chKey].Add(str);
            }

            foreach (var value in mapper.Values)
            {
                result.Add(value);
            }
            return result;
        }
        static void Main(string[] args)
        {
            var firstCase = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
            var result = GroupAnagrams(firstCase);

            Console.WriteLine(result);
        }
    }
}
