namespace IsSubsequence
{
    internal class Program
    {
        public static bool IsSubsequence(string s, string t)
        {
            var result = true;

            var isSubstringPresent = true;
            foreach (var chr in s)
            {
                if (!t.Contains(chr)) 
                {
                    result = false;
                    break;
                }
            }

            if (!isSubstringPresent) 
            {
                return result;
            }

            var sIndex = 0;
            foreach (var chr in s) 
            {
                var found = false;

                while (sIndex < t.Length) 
                {
                    if (t[sIndex] == chr) 
                    {
                        found = true;
                        sIndex++;
                        break;
                    }
                    sIndex++;
                }

                if (!found) 
                {
                    result = false;
                    break;
                }
            }

            return result;
        }
        static void Main(string[] args)
        {
            //Input: s = "abc", t = "ahbgdc"
            //Output: true
            // keep order "ace" is a subsequence of "abcde" while "aec" is not
            // case 2 s = "axc", t = "ahbgdc"
            var firstCaseS = "abc";
            var firstCaseT = "ahbgdc";

            var result = IsSubsequence(firstCaseS, firstCaseT);
            Console.WriteLine(result);
        }
    }
}
