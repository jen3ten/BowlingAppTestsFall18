using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BowlingKataFall18
{
    public class Game
    {
        List<int> rolls = new List<int>();
        private int totalScore;

        public int Score()
        {
            return totalScore; //Return a failing value first, like -1; then 0 returned to pass early test

            //if (rolls.Count == 12)
            //{
            //    return 300;
            //}
            //if (rolls.Count == 10)
            //{
            //    return rolls.Sum();
            //}
            //throw new GameNotFinishedException();
        }

        public void Roll(int pinCount)
        {
            //rolls.Add(pinCount);
            totalScore += pinCount;
        }
    }
}
