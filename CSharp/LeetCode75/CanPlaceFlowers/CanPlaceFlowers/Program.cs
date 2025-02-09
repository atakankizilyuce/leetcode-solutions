namespace CanPlaceFlowers
{
    internal class Program
    {
        public static bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            var result = false;
            if (flowerbed.Length == 0)
            {
                return result;
            }

            for (var i = 0; i < flowerbed.Length; i++)
            {
                if (n == 0) 
                {
                    break;
                }

                var counter = flowerbed[i];
                if (i - 1 >= 0)
                {
                    counter += flowerbed[i - 1];
                }
                if (i + 1 < flowerbed.Length)
                {
                    counter += flowerbed[i + 1];
                }

                if (counter != 0)
                {
                    continue;
                }
                else
                {
                    n--;
                    flowerbed[i] = 1;
                }
            }

            if (n == 0)
            {
                result = true;
            }

            return result;
        }

        static void Main(string[] args)
        {
            var firstCase = new int[] { 0, 0, 1, 0, 0 };
            var result = CanPlaceFlowers(firstCase,1);
        }
    }
}
