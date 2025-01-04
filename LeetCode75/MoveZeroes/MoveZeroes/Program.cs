namespace MoveZeroes
{
    internal class Program
    {
        public static void MoveZeroes(int[] nums)
        {
            var isNonZeroExist = false;
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    isNonZeroExist = true;
                    break;
                }
            }

            if (!isNonZeroExist)
            {
                return;
            }

            var zeroSize = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    zeroSize++;
                }

                if (zeroSize > 0 && nums[i] != 0)
                {
                    var temp = nums[i];
                    nums[i] = 0;
                    nums[i - zeroSize] = temp;
                }
            }
        }

        static void Main(string[] args)
        {
            var firstCase = new int[] { 0, 1, 0, 3, 12 };
            MoveZeroes(firstCase);
            Console.WriteLine(firstCase);
        }
    }
}
