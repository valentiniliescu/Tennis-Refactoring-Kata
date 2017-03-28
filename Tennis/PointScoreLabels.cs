namespace Tennis
{
    internal static class PointScoreLabels
    {
        private static readonly string[] Labels = { "Love", "Fifteen" , "Thirty", "Forty" };

        public static string GetScoreLabelForPoints(int points)
        {
            return Labels[points];
        }
    }
}