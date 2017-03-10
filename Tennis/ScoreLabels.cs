namespace Tennis
{
    static class ScoreLabels
    {
        private static readonly string[] Labels = { "Love", "Fifteen" , "Thirty", "Forty" };

        public static string GetLabelForScore(int score)
        {
            return Labels[score];
        }
    }
}