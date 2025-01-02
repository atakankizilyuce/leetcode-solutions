namespace KidsWithTheGreatestNumberOfCandies
{
    internal class Program
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            var result = new List<bool>();
            if (candies.Length == 0 || extraCandies == 0)
            {
                return result;
            }

            for (var i = 0; i < candies.Length; i++)
            {
                var candiesWithExtra = candies[i] + extraCandies;
                var status = true;
                for (var j = 0; j < candies.Length; j++)
                {
                    if (candiesWithExtra < candies[j])
                    {
                        status = false;
                        break;
                    }
                }
                result.Add(status);
            }

            return result;
        }
    }
}