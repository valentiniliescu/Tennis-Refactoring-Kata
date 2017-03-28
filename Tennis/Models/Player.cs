namespace Tennis.Models
{
    public class Player
    {
        public string Name { get; }

        public int Points { get; private set; }

        public Player(string name)
        {
            Name = name;
            Points = 0;
        }

        public void WonPoint()
        {
            Points++;
        }
    }
}
