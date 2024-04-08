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

        public void Roll()
        {
            Random rnd = new Random();
            int diceRoll = rnd.Next(1, 7);
            currentDieValue = diceRoll;
        }
    }
    

}
