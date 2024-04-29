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
            Debug.Assert(Value < 6, "Induvidual die rolls are over 6");
        }
    }
}
