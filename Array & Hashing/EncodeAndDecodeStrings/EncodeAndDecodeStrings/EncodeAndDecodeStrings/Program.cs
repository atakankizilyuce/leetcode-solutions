using System.Text;

namespace EncodeAndDecodeStrings
{
    public class Codec
    {
        private int Encoder { get; } = 1;

        // Encodes a list of strings to a single string.
        public string Encode(IList<string> strs)
        {
            var result = string.Empty;
            if (strs.Count == 0)
            {
                return result;
            }

            foreach (var str in strs)
            {
                foreach (var c in str)
                {
                    if (c == ',')
                    {

                    }
                    var unicode = (int)c;
                    if (unicode < 128)
                    {
                        result += (char)(unicode - Encoder);
                    }
                    else
                    {
                        result += c;
                    }
                }
                result += (char)128;
            }
            return result;
        }

        // Decodes a single string to a list of strings.
        public IList<string> Decode(string s)
        {
            var result = new List<string>();
            if (string.IsNullOrEmpty(s))
            {
                return result;
            }

            var currentString = new StringBuilder();
            foreach (var c in s)
            {
                var unicode = (int)c;
                if (unicode <= 128)
                {
                    if (unicode == 128)
                    {
                        result.Add(currentString.ToString());
                        currentString.Clear();
                    }
                    else
                    {
                        currentString.Append((char)(unicode + Encoder));
                    }
                }
                else
                {
                    currentString.Append(c);
                }
            }

            if (currentString.Length > 0)
            {
                result.Add(currentString.ToString());
            }

            return result;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var firstCase = new List<string>() { "Hello", "World" };

            var codec = new Codec();
            var encodedString = codec.Encode(firstCase);
            var decodedString = codec.Decode(encodedString);

            Console.WriteLine(encodedString);
            Console.WriteLine(decodedString);
        }
    }
}
