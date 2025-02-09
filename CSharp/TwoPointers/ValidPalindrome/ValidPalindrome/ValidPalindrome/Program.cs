namespace ValidPalindrome
{
    internal class Program
    {
        public static bool IsPalindrome(string s)
        {
            if (s.Length == 0)
            {
                return false;
            }

            var allowedChars = new char[]
            {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
            'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
            'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
            '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'
            };

            var cleanedStr = string.Empty;
            for (var i = 0; i < s.Length; i++) 
            {
                if (allowedChars.Contains(s[i]))
                {
                    cleanedStr += s[i];
                }
            }

            if (cleanedStr == " ")
            {
                return true;
            }

            var lowerStr = cleanedStr.ToLower();
            for (var i = 0; i < lowerStr.Length; i++) 
            {
                if (lowerStr[i] != lowerStr[lowerStr.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
        static void Main(string[] args)
        {
            var firstCase = "A man, a plan, a canal: Panama";
            var result = IsPalindrome(firstCase);
            Console.WriteLine(result);
        }
    }
}
