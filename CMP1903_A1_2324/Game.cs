using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CMP1903_A1_2324
{
    internal class SevensOut
    {
        public SevensOut()
        {
            Console.WriteLine("SEVENS OUT");

            Console.WriteLine("Pick a game mode\nPlay agianst computer [1]\nPlay against a player [2]");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Console.WriteLine("Player v Computer");

                int finalScore = 0;
                int doubleRoll;
                int total = 0;
                bool endGame = false;

                int total2 = 0;
                int finalScore2 = 0;

                while (!endGame)
                {
                    Die die1 = new Die();
                    Die die2 = new Die();

                    Console.WriteLine("Computers turn");

                    die1.Roll();
                    Console.WriteLine("Dice 1 rolled: " + die1.currentDieValue);

                    die2.Roll();
                    Console.WriteLine("Dice 2 rolled: " + die2.currentDieValue);

                    total = die1.currentDieValue + die2.currentDieValue;

                    Console.WriteLine("Your total is: " + total);


                    if (total == 7)
                    {
                        finalScore = total + finalScore;
                        Console.WriteLine("You rolled a 7 game will end after players turn");
                        endGame = true;
                    }

                    else if (die1.currentDieValue == die2.currentDieValue)
                    {
                        doubleRoll = die1.currentDieValue + die2.currentDieValue;
                        doubleRoll = doubleRoll * 2;
                        finalScore = doubleRoll + finalScore;
                        Console.WriteLine("double roll! Your points are doubled!");
                    }

                    else
                    {
                        finalScore = finalScore + total;
                    }

                    Console.WriteLine("Players turn");

                    die1.Roll();
                    Console.WriteLine("Dice 1 rolled: " + die1.currentDieValue);

                    die2.Roll();
                    Console.WriteLine("Dice 2 rolled: " + die2.currentDieValue);

                    total2 = die1.currentDieValue + die2.currentDieValue;

                    Console.WriteLine("Your total is: " + total2);

                    if (total2 == 7)
                    {
                        finalScore2 = total2 + finalScore2;
                        Console.WriteLine("You rolled a 7 game will end");
                        endGame = true;
                    }

                    else if (die1.currentDieValue == die2.currentDieValue)
                    {
                        doubleRoll = die1.currentDieValue + die2.currentDieValue;
                        doubleRoll = doubleRoll * 2;
                        finalScore2 = doubleRoll + finalScore2;
                        Console.WriteLine("double roll! Your points are doubled!");
                    }

                    else
                    {
                        finalScore2 = finalScore2 + total2;
                    }
                }
                Console.WriteLine("The Game has ended");
                Console.WriteLine("Computer got " + finalScore + "\nPlayer got " + finalScore2);
            }
            if (userInput == "2")
            {
                Console.WriteLine("Player v Player");

                int finalScore = 0;
                int doubleRoll;
                int total = 0;
                bool endGame = false;

                int total2 = 0;
                int finalScore2 = 0;

                while (!endGame)
                {
                    Die die1 = new Die();
                    Die die2 = new Die();

                    Console.WriteLine("Player 1 turn");

                    die1.Roll();
                    Console.WriteLine("Dice 1 rolled: " + die1.currentDieValue);

                    die2.Roll();
                    Console.WriteLine("Dice 2 rolled: " + die2.currentDieValue);

                    total = die1.currentDieValue + die2.currentDieValue;

                    Console.WriteLine("Your total is: " + total);


                    if (total == 7)
                    {
                        finalScore = total + finalScore;
                        Console.WriteLine("You rolled a 7 game will end after players turn");
                        endGame = true;
                    }

                    else if (die1.currentDieValue == die2.currentDieValue)
                    {
                        doubleRoll = die1.currentDieValue + die2.currentDieValue;
                        doubleRoll = doubleRoll * 2;
                        finalScore = doubleRoll + finalScore;
                        Console.WriteLine("double roll! Your points are doubled!");
                    }

                    else
                    {
                        finalScore = finalScore + total;
                    }

                    Console.WriteLine("Players 2 turn");

                    die1.Roll();
                    Console.WriteLine("Dice 1 rolled: " + die1.currentDieValue);

                    die2.Roll();
                    Console.WriteLine("Dice 2 rolled: " + die2.currentDieValue);

                    total2 = die1.currentDieValue + die2.currentDieValue;

                    Console.WriteLine("Your total is: " + total2);

                    if (total2 == 7)
                    {
                        finalScore2 = total2 + finalScore2;
                        Console.WriteLine("You rolled a 7 game will end");
                        endGame = true;
                    }

                    else if (die1.currentDieValue == die2.currentDieValue)
                    {
                        doubleRoll = die1.currentDieValue + die2.currentDieValue;
                        doubleRoll = doubleRoll * 2;
                        finalScore2 = doubleRoll + finalScore2;
                        Console.WriteLine("double roll! Your points are doubled!");
                    }

                    else
                    {
                        finalScore2 = finalScore2 + total2;
                    }
                }
                Console.WriteLine("The Game has ended");
                Console.WriteLine("Player 1 got " + finalScore + "\nPlayer 2 got " + finalScore2);
            }
        }
        internal class ThreeOrMore
        {
            public ThreeOrMore()
            {
                Console.WriteLine("THREE OR MORE");
                int finalScore = 0;
                while (finalScore <= 20)
                {
                    Die die1 = new Die();
                    Die die2 = new Die();
                    Die die3 = new Die();
                    Die die4 = new Die();
                    Die die5 = new Die();

                    die1.Roll();
                    Console.WriteLine("Dice 1 rolled: " + die1.currentDieValue);

                    die2.Roll();
                    Console.WriteLine("Dice 2 rolled: " + die2.currentDieValue);

                    die3.Roll();
                    Console.WriteLine("Dice 3 rolled: " + die3.currentDieValue);

                    die4.Roll();
                    Console.WriteLine("Dice 4 rolled: " + die4.currentDieValue);

                    die5.Roll();
                    Console.WriteLine("Dice 5 rolled: " + die5.currentDieValue);


                    //5 of a kind
                    if (die1.currentDieValue == die2.currentDieValue &&
                        die1.currentDieValue == die3.currentDieValue &&
                        die1.currentDieValue == die4.currentDieValue &&
                        die1.currentDieValue == die5.currentDieValue)
                    {
                        Console.WriteLine("5 OF A KIND!");
                        finalScore = finalScore + 12;
                        continue;
                    }

                    //4 of a kind
                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue ||
                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                        die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                        die2.currentDieValue == die3.currentDieValue && die2.currentDieValue == die4.currentDieValue && die2.currentDieValue == die5.currentDieValue)
                    {
                        Console.WriteLine("4 of a kind");
                        finalScore = finalScore + 6;
                        continue;

                    }

                    //3 of a kind
                    else if ((die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue) ||
                        (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die4.currentDieValue) ||
                        (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die5.currentDieValue) ||
                        (die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue) ||
                        (die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die5.currentDieValue) ||
                        (die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue) ||
                        (die2.currentDieValue == die3.currentDieValue && die2.currentDieValue == die4.currentDieValue) ||
                        (die2.currentDieValue == die3.currentDieValue && die2.currentDieValue == die5.currentDieValue) ||
                        (die2.currentDieValue == die4.currentDieValue && die2.currentDieValue == die5.currentDieValue) ||
                        (die3.currentDieValue == die4.currentDieValue && die3.currentDieValue == die5.currentDieValue))
                    {
                        Console.WriteLine("3 of a kind");
                        finalScore = finalScore + 3;
                        continue;
                    }

                    //two of a kind
                    else if (die1.currentDieValue == die2.currentDieValue ||
                        die1.currentDieValue == die3.currentDieValue ||
                        die1.currentDieValue == die4.currentDieValue ||
                        die1.currentDieValue == die5.currentDieValue ||
                        die2.currentDieValue == die3.currentDieValue ||
                        die2.currentDieValue == die4.currentDieValue ||
                        die2.currentDieValue == die5.currentDieValue ||
                        die3.currentDieValue == die4.currentDieValue ||
                        die3.currentDieValue == die5.currentDieValue ||
                        die4.currentDieValue == die5.currentDieValue)
                    {
                        Console.WriteLine("You threw two of a kind");
                        Console.WriteLine("You can either\nthow the remaining dice [1]\n Throw all of them [2].\n Please pick one of the two options\n[1]/[2]");
                        string userinput = Console.ReadLine();
                        if (userinput == "1")
                        {

                            if (die1.currentDieValue == die2.currentDieValue)
                            {
                                die3.Roll();
                                Console.WriteLine("Dice 3 rolled: " + die3.currentDieValue);

                                die4.Roll();
                                Console.WriteLine("Dice 4 rolled: " + die4.currentDieValue);

                                die5.Roll();
                                Console.WriteLine("Dice 5 rolled: " + die5.currentDieValue);
                                continue;

                            }
                            else if (die1.currentDieValue == die3.currentDieValue)
                            {
                                die2.Roll();
                                Console.WriteLine("Dice 2 rolled: " + die2.currentDieValue);

                                die4.Roll();
                                Console.WriteLine("Dice 4 rolled: " + die4.currentDieValue);

                                die5.Roll();
                                Console.WriteLine("Dice 5 rolled: " + die5.currentDieValue);
                                continue;

                            }
                            else if (die1.currentDieValue == die4.currentDieValue)
                            {
                                die2.Roll();
                                Console.WriteLine("Dice 2 rolled: " + die2.currentDieValue);

                                die3.Roll();
                                Console.WriteLine("Dice 3 rolled: " + die3.currentDieValue);

                                die5.Roll();
                                Console.WriteLine("Dice 5 rolled: " + die5.currentDieValue);
                                continue;

                            }
                            else if (die1.currentDieValue == die5.currentDieValue)
                            {
                                die2.Roll();
                                Console.WriteLine("Dice 2 rolled: " + die2.currentDieValue);

                                die3.Roll();
                                Console.WriteLine("Dice 3 rolled: " + die3.currentDieValue);

                                die4.Roll();
                                Console.WriteLine("Dice 4 rolled: " + die4.currentDieValue);
                                continue;
                            }
                            else if (die2.currentDieValue == die3.currentDieValue)
                            {
                                die1.Roll();
                                Console.WriteLine("Dice 1 rolled: " + die1.currentDieValue);

                                die4.Roll();
                                Console.WriteLine("Dice 4 rolled: " + die4.currentDieValue);

                                die5.Roll();
                                Console.WriteLine("Dice 5 rolled: " + die5.currentDieValue);
                                continue;
                            }
                            else if (die2.currentDieValue == die4.currentDieValue)
                            {
                                die1.Roll();
                                Console.WriteLine("Dice 1 rolled: " + die1.currentDieValue);

                                die3.Roll();
                                Console.WriteLine("Dice 3 rolled: " + die3.currentDieValue);

                                die5.Roll();
                                Console.WriteLine("Dice 5 rolled: " + die5.currentDieValue);
                                continue;
                            }
                            else if (die2.currentDieValue == die5.currentDieValue)
                            {
                                die1.Roll();
                                Console.WriteLine("Dice 1 rolled: " + die1.currentDieValue);

                                die4.Roll();
                                Console.WriteLine("Dice 4 rolled: " + die4.currentDieValue);

                                die3.Roll();
                                Console.WriteLine("Dice 3 rolled: " + die3.currentDieValue);
                                continue;
                            }
                            else if (die3.currentDieValue == die4.currentDieValue)
                            {
                                die1.Roll();
                                Console.WriteLine("Dice 1 rolled: " + die1.currentDieValue);

                                die2.Roll();
                                Console.WriteLine("Dice 2 rolled: " + die2.currentDieValue);

                                die5.Roll();
                                Console.WriteLine("Dice 5 rolled: " + die5.currentDieValue);
                                continue;
                            }
                            else if (die3.currentDieValue == die5.currentDieValue)
                            {
                                die1.Roll();
                                Console.WriteLine("Dice 1 rolled: " + die1.currentDieValue);

                                die2.Roll();
                                Console.WriteLine("Dice 2 rolled: " + die2.currentDieValue);

                                die4.Roll();
                                Console.WriteLine("Dice 4 rolled: " + die4.currentDieValue);
                                continue;
                            }
                            else if (die5.currentDieValue == die4.currentDieValue)
                            {
                                die1.Roll();
                                Console.WriteLine("Dice 1 rolled: " + die1.currentDieValue);

                                die2.Roll();
                                Console.WriteLine("Dice 2 rolled: " + die2.currentDieValue);

                                die3.Roll();
                                Console.WriteLine("Dice 3 rolled: " + die3.currentDieValue);
                                continue;
                            }
                        }
                        else if (userinput == "2")

                            die1.Roll();
                        Console.WriteLine("Dice 1 rolled: " + die1.currentDieValue);

                        die2.Roll();
                        Console.WriteLine("Dice 2 rolled: " + die2.currentDieValue);

                        die3.Roll();
                        Console.WriteLine("Dice 3 rolled: " + die3.currentDieValue);

                        die4.Roll();
                        Console.WriteLine("Dice 4 rolled: " + die4.currentDieValue);

                        die5.Roll();
                        Console.WriteLine("Dice 5 rolled: " + die5.currentDieValue);

                        if (die1.currentDieValue == die2.currentDieValue &&
                            die1.currentDieValue == die3.currentDieValue &&
                            die1.currentDieValue == die4.currentDieValue &&
                            die1.currentDieValue == die5.currentDieValue)
                        {
                            Console.WriteLine("5 OF A KIND!");
                            finalScore = finalScore + 12;
                            continue;
                        }

                        if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue ||
                            die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                            die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                            die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                            die2.currentDieValue == die3.currentDieValue && die2.currentDieValue == die4.currentDieValue && die2.currentDieValue == die5.currentDieValue)
                        {
                            Console.WriteLine("4 of a kind");
                            finalScore = finalScore + 6;
                            continue;
                        }

                        if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue ||
                            die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die4.currentDieValue ||
                            die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                            die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue ||
                            die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                            die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                            die2.currentDieValue == die3.currentDieValue && die2.currentDieValue == die4.currentDieValue ||
                            die2.currentDieValue == die3.currentDieValue && die2.currentDieValue == die5.currentDieValue ||
                            die2.currentDieValue == die4.currentDieValue && die2.currentDieValue == die5.currentDieValue ||
                            die3.currentDieValue == die4.currentDieValue && die3.currentDieValue == die5.currentDieValue)
                        {
                            Console.WriteLine("3 of a kind");
                            finalScore = finalScore + 3;
                            continue;
                        }

                        else
                        {
                            Console.WriteLine("Unlucky no roll");
                            continue;
                        }
                    }

                }
            }
        }
    }
}


