namespace Dota2Senate
{
    internal class Program
    {
        public static string PredictPartyVictory(string senate)
        {
            var radiantVotes = new List<int>();
            var direVotes = new List<int>();

            // Dire & radiant index map
            for (var i = 0; i < senate.Length; i++)
            {
                if (senate[i] == 'R')
                {
                    radiantVotes.Add(i);
                }
                else
                {
                    direVotes.Add(i);
                }
            }

            while (radiantVotes.Count > 0 && direVotes.Count > 0)
            {
                var radiantVote = radiantVotes[0];
                var direVote = direVotes[0];

                // Ban one senator's right
                if (radiantVote < direVote)
                {
                    radiantVotes.Add(radiantVote + senate.Length); // Move to end
                    radiantVotes.RemoveAt(0);       // Remove first senate
                    direVotes.RemoveAt(0);          // Ban
                }
                else
                {
                    direVotes.Add(direVote + senate.Length); // Move to end
                    direVotes.RemoveAt(0);         // Remove first senate
                    radiantVotes.RemoveAt(0);      // Ban
                }
            }

            return radiantVotes.Count > 0 ? "Radiant" : "Dire";
        }
        static void Main(string[] args)
        {
            var firstCase = "RD";
            var result = PredictPartyVictory(firstCase);
        }
    }
}
