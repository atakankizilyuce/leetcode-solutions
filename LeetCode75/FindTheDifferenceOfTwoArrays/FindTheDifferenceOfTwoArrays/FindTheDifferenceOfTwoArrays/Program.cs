namespace FindTheDifferenceOfTwoArrays
{
    internal class Program
    {
        public static IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            var result = new List<IList<int>>();

            var nums1Result = new List<int>();
            foreach (var num in nums1)
            {
                if (!nums2.Contains(num) && !nums1Result.Contains(num))
                {
                    nums1Result.Add(num);
                }
            }
            result.Add(nums1Result);

            var nums2Result = new List<int>();
            foreach (var num in nums2)
            {
                if (!nums1.Contains(num) && !nums2Result.Contains(num))
                {
                    nums2Result.Add(num);
                }
            }
            result.Add(nums2Result);

            return result;
        }

        static void Main(string[] args)
        {
            var firstCase_nums1 = new int[] { 1, 2, 3 };
            var firstCase_nums2 = new int[] { 2, 4, 6 };
            var result = FindDifference(firstCase_nums1, firstCase_nums2);
        }
    }
}
