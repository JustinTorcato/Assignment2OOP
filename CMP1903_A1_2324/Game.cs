using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    class game
    {
        Die die1 = new Die();
        die1.RolledNum = die1.Roll();
            
        Die die2 = new Die();
        die2.RolledNum = die2.Roll();
            
        Die die3 = new Die();
        die3.RolledNum = die3.Roll();
    }
    

}
