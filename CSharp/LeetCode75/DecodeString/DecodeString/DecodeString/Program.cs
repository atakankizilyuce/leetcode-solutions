using System.Security;
using System.Text;

namespace DecodeString
{
    internal class Program
    {
        public static string DecodeString(string s)
        {
            var stack = new Stack<(int, StringBuilder)>();
            var currentString = new StringBuilder();

            var currentCount = 0;
            foreach (var chr in s)
            {
                if (char.IsDigit(chr))
                {
                    // currentCount * 10: Shifts the current number one digit to the left (tens, hundreds).
                    // (chr - '0'): Adds the numeric value of the new character
                    // Example: "105[b]"
                    // '1' → currentCount = 1
                    // '0' → currentCount = 1 * 10 + 0 = 10
                    // '2' → currentCount = 10 * 10 + 5 = 105
                    currentCount = currentCount * 10 + (chr - '0');
                }
                else if (chr == '[')
                {
                    stack.Push((currentCount, currentString));
                    currentCount = 0;
                    currentString = new StringBuilder();
                }
                else if (chr == ']')
                {
                    var (repeatCount, previousString) = stack.Pop();
                    var repeatedString = new StringBuilder();

                    for (var i = 0; i < repeatCount; i++)
                    {
                        repeatedString.Append(currentString);
                    }

                    currentString = previousString.Append(repeatedString);
                }
                else
                {
                    currentString.Append(chr);
                }
            }

            return currentString.ToString();
        }
        static void Main(string[] args)
        {
            var firstCase = "3[a]2[bc]";
            var result = DecodeString(firstCase); // aaabcbc
            Console.WriteLine(result);
            
        }
    }
}
