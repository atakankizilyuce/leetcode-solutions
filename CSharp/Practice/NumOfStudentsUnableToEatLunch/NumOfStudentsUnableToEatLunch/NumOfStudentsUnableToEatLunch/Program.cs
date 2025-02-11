namespace NumOfStudentsUnableToEatLunch
{
    public class Solution
    {
        public int CountStudents(int[] students, int[] sandwiches)
        {
            var result = students.Length;

            var counter = new int[2];
            for (var i = 0; i < students.Length; i++)
            {
                counter[students[i]]++;
            }

            for (var i = 0; i < students.Length; i++)
            {
                if (counter[sandwiches[i]] > 0)
                {
                    result--;
                    counter[sandwiches[i]]--;
                }
                else
                {
                    break;
                }
            }

            return result;
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            var firstCaseStudents = new int[] { 1, 1, 0, 0 };
            var firstCaseSandwiches = new int[] { 0, 1, 0, 1 };

            var solution = new Solution();
            var result = solution.CountStudents(firstCaseStudents, firstCaseSandwiches);
            Console.WriteLine(result);
        }
    }
}
