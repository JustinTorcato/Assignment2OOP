using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        Game dieValue = new Game();
        public void dieTest(int Value)
        {
            Debug.Assert(Value <= 6, "Induvidual die rolls are over 6");
            Console.ReadLine();
        }
        public void totalTest(int Value, int die1, int die2, int die3)
        {
            Debug.Assert(Value == die1 + die2 + die3, "Dice rolls do not add up");
            Console.ReadLine();
        }
    }
}
