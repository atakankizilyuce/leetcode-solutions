namespace ValidAnagram
{
    internal class Program
    {
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            char[] sArray = s.ToCharArray();
            char[] tArray = t.ToCharArray();

            Array.Sort(sArray);
            Array.Sort(tArray);

            var sString = new string(sArray);
            var tString = new string(tArray);

            return sString == tString;
        }

        static void Main(string[] args)
        {
            var result = IsAnagram("cat", "tac");
            Console.WriteLine(result);
        }
    }
}
