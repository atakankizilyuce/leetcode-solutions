namespace EqualRowAndColumnPairs
{
    internal class Program
    {
        public static int EqualPairs(int[][] grid)
        {
            var result = 0;

            var rowHashes = new Dictionary<long, int>();
            foreach (var row in grid)
            {
                var rowHash = GenerateHash(row);
                if (!rowHashes.ContainsKey(rowHash))
                {
                    rowHashes[rowHash] = 0;
                }
                rowHashes[rowHash]++;
            }

            for (var columnIndex = 0; columnIndex < grid.Length; columnIndex++)
            {
                var column = new int[grid.Length];
                for (var rowIndex = 0; rowIndex < grid.Length; rowIndex++)
                {
                    column[rowIndex] = grid[rowIndex][columnIndex];
                }

                var columnHash = GenerateHash(column);
                if (rowHashes.ContainsKey(columnHash))
                {
                    result += rowHashes[columnHash];
                }
            }

            return result;
        }

        private static int GenerateHash(int[] arr)
        {
            var hash = 23;
            foreach (var num in arr)
            {
                hash = hash * 17 + num;
            }
            return hash;
        }

        static void Main(string[] args)
        {
            int[][] firstCase = {
                new int[] { 3, 2, 1 },
                new int[] { 1, 7, 6 },
                new int[] { 2, 7, 7 }
            };

            var result = EqualPairs(firstCase);
            Console.WriteLine(result);
        }
    }
}