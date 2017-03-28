namespace Tennis.Models
{
    public class Player
    {
        public string Name { get; }

        public int Points { get; private set; }

        public Player(string name): this(name, 0)
        {
        }

        internal Player(string name, int points)
        {
            Name = name;
            Points = points;
        }

        public void WonPoint()
        {
            Points++;
        }
    }
}
