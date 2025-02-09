namespace AsteroidCollision
{
    internal class Program
    {
        public static int[] AsteroidCollision(int[] asteroids)
        {
            var result = new List<int>();

            foreach (var asteroid in asteroids)
            {
                var destroyed = false;
                while (result.Count > 0 && asteroid < 0 && result[^1] > 0)
                {
                    var top = result[^1];
                    if (top < -asteroid)
                    {
                        result.RemoveAt(result.Count - 1);
                    }
                    else if (top == -asteroid)
                    {
                        result.RemoveAt(result.Count - 1);
                        destroyed = true;
                        break;
                    }
                    else
                    {
                        destroyed = true;
                        break;
                    }
                }

                if (!destroyed)
                {
                    result.Add(asteroid);
                }
            }

            return result.ToArray();
        }

        static void Main(string[] args)
        {
            var firstCase = new int[] { 5, 10, -5 };
            var result = AsteroidCollision(firstCase);
            Console.WriteLine(result);
        }
    }
}
