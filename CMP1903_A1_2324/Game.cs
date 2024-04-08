using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        public Game()
        {
            Die die1 = new Die();
            Die die2 = new Die();
            Die die3 = new Die();

            int currentDieValue = die1.Roll();
        }

    }
}
