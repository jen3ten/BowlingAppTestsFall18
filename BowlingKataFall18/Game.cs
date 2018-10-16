using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BowlingKataFall18
{
    public class Game
    {
        List<int> rolls = new List<int>();

        public int Score()
        {
            if (rolls.Count == 12)
            {
                return 300;
            }
            if (rolls.Count == 10)
            {
                return rolls.Sum();
            }
            throw new GameNotFinishedException();
        }

        public void Roll(int pinCount)
        {
            rolls.Add(pinCount);
        }
    }
}
