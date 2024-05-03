using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    public class Die
    {
        public int currentDieValue;

        private static Random random = new Random();
        public void Roll()                                      //Roll command. Randomly selects number from 1-7
        {                                                       //Sets the number to currentDieValue and used by object
            int diceRoll = random.Next(1, 7);
            currentDieValue = diceRoll;
        }
    }
}
