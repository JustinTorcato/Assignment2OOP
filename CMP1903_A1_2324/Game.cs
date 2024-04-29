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

            int total = 0;

            die1.Roll();
           
            Console.WriteLine("dice one rolled " + die1.currentDieValue);
            total += die1.currentDieValue;

            die2.Roll();
            
            Console.WriteLine("dice two rolled " + die2.currentDieValue);
            total += die2.currentDieValue;

            die3.Roll();
            Console.WriteLine("dice three rolled " + die3.currentDieValue);
            total += die3.currentDieValue;

            Console.WriteLine(total);

        }
    }
    internal class GameTest
    {
        Testing tdieTest(die1.currentDieValue)est = new Testing();
        test.
    }
}
