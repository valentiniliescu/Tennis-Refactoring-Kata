namespace Tennis.Models
{
    public class Player
    {
        public string Name { get; }

        public int Points { get; private set; }

        public Player(string name): this(name, 0)
        {
        }

        internal Player(string name, int initialPoints)
        {
            Name = name;
            Points = initialPoints;
        }

        public void WonPoint()
        {
            Points++;
        }
    }
}
