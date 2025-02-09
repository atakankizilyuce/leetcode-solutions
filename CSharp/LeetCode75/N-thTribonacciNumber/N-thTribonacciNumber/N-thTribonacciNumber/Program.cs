namespace N_thTribonacciNumber
{
    internal class Program
    {
        public static int Tribonacci(int n)
        {
            var result = 0;
            if (n == 0)
            {
                return result;
            }

            int a = 0, b = 1, c = 1, d;
            while (n-- > 2)
            {
                d = a + b + c;
                a = b;
                b = c;
                c = d;
            }
            result = c;
            return result;
        }

        static void Main(string[] args)
        {
            var firstCase = 25;
            var result = Tribonacci(firstCase);
            Console.WriteLine(result);
        }
    }
}
