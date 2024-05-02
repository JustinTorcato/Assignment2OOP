using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static CMP1903_A1_2324.SevensOut;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please pick a game\nSevens Out [1]\nThree Or More [2]");
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                SevensOut sevensOut = new SevensOut();
            }
            else if (userInput == "2")
            {
                ThreeOrMore threeOrMore = new ThreeOrMore();
            }
            else
            {
                Console.WriteLine("User input not recognised");
            }
            Console.ReadLine();

        }
    }
}
