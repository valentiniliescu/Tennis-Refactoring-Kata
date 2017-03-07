using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis.Models
{
    public class Player
    {
        public string Name { get; }

        public int Score { get; private set; }

        public Player(string name)
        {
            this.Name = name;
            this.Score = 0;
        }

        public void WonPoint()
        {
            this.Score++;
        }
    }
}
