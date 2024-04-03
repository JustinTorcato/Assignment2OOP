using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    class Die
    {
        public static void roll()
        {
            //https://youtu.be/1gSFd-YVFP8?si=Rpdr2gLzbcuNrAvP

            Random random = new Random();
            int num = random.Next(1, 7);
            Console.WriteLine(num);
        }
    }
}
