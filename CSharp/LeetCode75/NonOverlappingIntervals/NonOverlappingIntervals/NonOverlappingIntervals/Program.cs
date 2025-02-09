namespace NonOverlappingIntervals
{
    internal class Program
    {
        public static int EraseOverlapIntervals(int[][] intervals)
        {
            var result = 0;

            if (intervals.Length == 0) 
            {
                return result;
            }

            for (var i = 0; i < intervals.Length - 1; i++)
            {
                for (var j = i + 1; j < intervals.Length; j++)
                {
                    if (intervals[i][1] > intervals[j][1])
                    {
                        var temp = intervals[i];
                        intervals[i] = intervals[j];
                        intervals[j] = temp;
                    }
                }
            }

            var nonOverlapping = 0;
            var lastEnd = int.MinValue;
            foreach (var interval in intervals)
            {
                if (interval[0] >= lastEnd)
                {
                    nonOverlapping++;
                    lastEnd = interval[1];
                }
            }
            result = intervals.Length - nonOverlapping;
            
            return result;
        }
        static void Main(string[] args)
        {
            var firstCase = new int[][] { [1, 2], [2, 3], [3, 4], [1, 3] };
            var result = EraseOverlapIntervals(firstCase);
            Console.WriteLine(result);
        }
    }
}