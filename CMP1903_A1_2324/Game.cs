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
        //Method Sevens Out
        public SevensOut()
        {
            Console.WriteLine("SEVENS OUT");
            //Asks to play against computer or player

            Console.WriteLine("Pick a game mode\nPlay agianst computer [1]\nPlay against a player [2]");
            string userInput = Console.ReadLine();

            //1 will play computer
            if (userInput == "1")
            {
                Console.WriteLine("Player v Computer");

                int finalScore = 0;             //Used for final score at the end of game
                int doubleRoll;                 //used to calculate the double roll
                int total = 0;                  //Used to calculate the total of the two die
                bool endGame = false;           //Used to end the game. Set to false

                int total2 = 0;                 //These two vairiables are used the same way but for other player/computer
                int finalScore2 = 0;

                while (!endGame)                                                                      //Game in a while loop. Loop ends when endGame is set to true
                {
                    Die die1 = new Die();                                                             //Two die objects that hold number
                    Die die2 = new Die();

                    Console.WriteLine("Computers turn");

                    die1.Roll();                                                                      //Roll command relating to Die.cs
                    Console.WriteLine("Dice 1 rolled: " + die1.currentDieValue);

                    die2.Roll();
                    Console.WriteLine("Dice 2 rolled: " + die2.currentDieValue);

                    total = die1.currentDieValue + die2.currentDieValue;                              //Vairiable total and currentDieValue used

                    Console.WriteLine("Your total is: " + total);


                    if (total == 7)                                                                   //Only exacutes when total == 7. Will end the game after player plays
                    {
                        finalScore = total + finalScore;                                              //This will be in multiple code blocks to calculate the final score at the end of the game
                        Console.WriteLine("You rolled a 7 game will end after players turn");
                        endGame = true;                                                               //Game is ended by setting endGame = true
                    }

                    else if (die1.currentDieValue == die2.currentDieValue)                            //IF statment for when a player rolls a double
                    {
                        doubleRoll = die1.currentDieValue + die2.currentDieValue;
                        doubleRoll = doubleRoll * 2;
                        finalScore = doubleRoll + finalScore;                                         //This is added to final score
                        Console.WriteLine("double roll! Your points are doubled!");
                    }

                    else
                    {
                        finalScore = finalScore + total;                                              //else statement to allow for numbers to be added to the score
                    }

                    Console.WriteLine("Players turn");                                       

                    die1.Roll();
                    Console.WriteLine("Dice 1 rolled: " + die1.currentDieValue);                      //Same Roll command for the player
                                                                                                      //Code repeates no differnce
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
                Console.WriteLine("The Game has ended");                                              //Final score is displayed
                Console.WriteLine("Computer got " + finalScore + "\nPlayer got " + finalScore2);
            }
            else if (userInput == "2")                                                                //Same code with only differnce being player instead of computer
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

        internal class ThreeOrMore                                                                                  //Game Three or more
        {
            public Random random = new Random();
            public ThreeOrMore()
            {
                Console.WriteLine("THREE OR MORE");
                Console.WriteLine("Pick a game mode\nPlay agianst computer [1]\nPlay against a player [2]");
                string userInput = Console.ReadLine();                                                              //Similar to the previous game. Asks user to pick a gamemode

                if (userInput == "1")
                {
                    Console.WriteLine("Playing against computer");
                    int finalScore = 0;                                                                             //Final score for Computer/Player and Player
                    int finalScore2 = 0;

                    while (finalScore <= 20 || finalScore2 <= 20)                                                   //While loop ends when player scores higher then 20
                    {
                        Die die1 = new Die();
                        Die die2 = new Die();
                        Die die3 = new Die();
                        Die die4 = new Die();
                        Die die5 = new Die();

                        Console.WriteLine("Computers turn");

                        die1.Roll();                                                                                //Die rolled with 5x die
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
                        if (die1.currentDieValue == die2.currentDieValue &&                                        //checks every possible combinatoion
                            die1.currentDieValue == die3.currentDieValue &&
                            die1.currentDieValue == die4.currentDieValue &&
                            die1.currentDieValue == die5.currentDieValue)
                        {
                            Console.WriteLine("5 OF A KIND!");
                            finalScore = finalScore + 12;                                                          //Gives points when if statement is satisfied then displays current points
                            Console.WriteLine("Score is: " + finalScore);
                            
                        }

                        //4 of a kind
                        else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue ||
                            die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                            die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                            die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                            die2.currentDieValue == die3.currentDieValue && die2.currentDieValue == die4.currentDieValue && die2.currentDieValue == die5.currentDieValue)
                        {
                            Console.WriteLine("4 of a kind");                                                                                       //Same code excepts compares two die                                   
                            finalScore = finalScore + 6;
                            Console.WriteLine("Score is: " + finalScore);
                            
                        }

                        //3 of a kind
                        else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue ||                  
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
                            Console.WriteLine("Score is: " + finalScore);
                            
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

                            int randomNum = random.Next(1, 2);                                                   //For computer the option to roll die is randomised
                            if (randomNum == 1)
                            {

                                if (die1.currentDieValue == die2.currentDieValue)
                                {
                                    die3.Roll();
                                    Console.WriteLine("Dice 3 rolled: " + die3.currentDieValue);

                                    die4.Roll();
                                    Console.WriteLine("Dice 4 rolled: " + die4.currentDieValue);

                                    die5.Roll();
                                    Console.WriteLine("Dice 5 rolled: " + die5.currentDieValue);

                                    //five of a kind
                                    if (die1.currentDieValue == die2.currentDieValue &&                          //If statments are repeated here until 3 of a kind
                                        die1.currentDieValue == die3.currentDieValue &&                          
                                        die1.currentDieValue == die4.currentDieValue &&
                                        die1.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("5 OF A KIND!");
                                        finalScore = finalScore + 12;
                                        Console.WriteLine("Score is: " + finalScore);
                                        
                                    }

                                    //four of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die2.currentDieValue == die3.currentDieValue && die2.currentDieValue == die4.currentDieValue && die2.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("4 of a kind");
                                        finalScore = finalScore + 6;
                                        Console.WriteLine("Score is: " + finalScore);
                                        
                                    }
                                    //three of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die4.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue ||
                                        die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||                   //There is no two of a kind
                                        die2.currentDieValue == die3.currentDieValue && die2.currentDieValue == die4.currentDieValue ||
                                        die2.currentDieValue == die3.currentDieValue && die2.currentDieValue == die5.currentDieValue ||
                                        die2.currentDieValue == die4.currentDieValue && die2.currentDieValue == die5.currentDieValue ||
                                        die3.currentDieValue == die4.currentDieValue && die3.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("3 of a kind");
                                        finalScore = finalScore + 3;
                                        Console.WriteLine("Score is: " + finalScore);
                                        
                                    }
                                }
                                else if (die1.currentDieValue == die3.currentDieValue)
                                {
                                    die2.Roll();
                                    Console.WriteLine("Dice 2 rolled: " + die2.currentDieValue);

                                    die4.Roll();
                                    Console.WriteLine("Dice 4 rolled: " + die4.currentDieValue);

                                    die5.Roll();
                                    Console.WriteLine("Dice 5 rolled: " + die5.currentDieValue);
                                    //five of a kind
                                    if (die1.currentDieValue == die2.currentDieValue &&
                                        die1.currentDieValue == die3.currentDieValue &&
                                        die1.currentDieValue == die4.currentDieValue &&
                                        die1.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("5 OF A KIND!");
                                        finalScore = finalScore + 12;
                                        Console.WriteLine("Score is: " + finalScore);
                                        
                                    }

                                    //four of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die2.currentDieValue == die3.currentDieValue && die2.currentDieValue == die4.currentDieValue && die2.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("4 of a kind");
                                        finalScore = finalScore + 6;
                                        Console.WriteLine("Score is: " + finalScore);
                                        
                                    }
                                    //three of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue ||
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
                                        Console.WriteLine("Score is: " + finalScore);
                                        
                                    }
                                }
                                else if (die1.currentDieValue == die4.currentDieValue)
                                {
                                    die2.Roll();
                                    Console.WriteLine("Dice 2 rolled: " + die2.currentDieValue);

                                    die3.Roll();
                                    Console.WriteLine("Dice 3 rolled: " + die3.currentDieValue);

                                    die5.Roll();
                                    Console.WriteLine("Dice 5 rolled: " + die5.currentDieValue);
                                    //five of a kind
                                    if (die1.currentDieValue == die2.currentDieValue &&
                                        die1.currentDieValue == die3.currentDieValue &&
                                        die1.currentDieValue == die4.currentDieValue &&
                                        die1.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("5 OF A KIND!");
                                        finalScore = finalScore + 12;
                                        Console.WriteLine("Score is: " + finalScore);
                                        
                                    }

                                    //four of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die2.currentDieValue == die3.currentDieValue && die2.currentDieValue == die4.currentDieValue && die2.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("4 of a kind");
                                        finalScore = finalScore + 6;
                                        Console.WriteLine("Score is: " + finalScore);
                                        
                                    }
                                    //three of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue ||
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
                                        Console.WriteLine("Score is: " + finalScore);
                                        
                                    }

                                }
                                else if (die1.currentDieValue == die5.currentDieValue)
                                {
                                    die2.Roll();
                                    Console.WriteLine("Dice 2 rolled: " + die2.currentDieValue);

                                    die3.Roll();
                                    Console.WriteLine("Dice 3 rolled: " + die3.currentDieValue);

                                    die4.Roll();
                                    Console.WriteLine("Dice 4 rolled: " + die4.currentDieValue);
                                    //five of a kind
                                    if (die1.currentDieValue == die2.currentDieValue &&
                                        die1.currentDieValue == die3.currentDieValue &&
                                        die1.currentDieValue == die4.currentDieValue &&
                                        die1.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("5 OF A KIND!");
                                        finalScore = finalScore + 12;
                                        Console.WriteLine("Score is: " + finalScore);
                                        
                                    }

                                    //four of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die2.currentDieValue == die3.currentDieValue && die2.currentDieValue == die4.currentDieValue && die2.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("4 of a kind");
                                        finalScore = finalScore + 6;
                                        Console.WriteLine("Score is: " + finalScore);
                                        
                                    }
                                    //three of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue ||
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
                                        Console.WriteLine("Score is: " + finalScore);
                                        
                                    }
                                }
                                else if (die2.currentDieValue == die3.currentDieValue)
                                {
                                    die1.Roll();
                                    Console.WriteLine("Dice 1 rolled: " + die1.currentDieValue);

                                    die4.Roll();
                                    Console.WriteLine("Dice 4 rolled: " + die4.currentDieValue);

                                    die5.Roll();
                                    Console.WriteLine("Dice 5 rolled: " + die5.currentDieValue);
                                    //five of a kind
                                    if (die1.currentDieValue == die2.currentDieValue &&
                                        die1.currentDieValue == die3.currentDieValue &&
                                        die1.currentDieValue == die4.currentDieValue &&
                                        die1.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("5 OF A KIND!");
                                        finalScore = finalScore + 12;
                                        Console.WriteLine("Score is: " + finalScore);
                                        
                                    }

                                    //four of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die2.currentDieValue == die3.currentDieValue && die2.currentDieValue == die4.currentDieValue && die2.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("4 of a kind");
                                        finalScore = finalScore + 6;
                                        Console.WriteLine("Score is: " + finalScore);
                                        
                                    }
                                    //three of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue ||
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
                                        Console.WriteLine("Score is: " + finalScore);
                                        
                                    }
                                }
                                else if (die2.currentDieValue == die4.currentDieValue)
                                {
                                    die1.Roll();
                                    Console.WriteLine("Dice 1 rolled: " + die1.currentDieValue);

                                    die3.Roll();
                                    Console.WriteLine("Dice 3 rolled: " + die3.currentDieValue);

                                    die5.Roll();
                                    Console.WriteLine("Dice 5 rolled: " + die5.currentDieValue);
                                    //five of a kind
                                    if (die1.currentDieValue == die2.currentDieValue &&
                                        die1.currentDieValue == die3.currentDieValue &&
                                        die1.currentDieValue == die4.currentDieValue &&
                                        die1.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("5 OF A KIND!");
                                        finalScore = finalScore + 12;
                                        Console.WriteLine("Score is: " + finalScore);
                                        
                                    }

                                    //four of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die2.currentDieValue == die3.currentDieValue && die2.currentDieValue == die4.currentDieValue && die2.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("4 of a kind");
                                        finalScore = finalScore + 6;
                                        Console.WriteLine("Score is: " + finalScore);
                                        
                                    }
                                    //three of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue ||
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
                                        Console.WriteLine("Score is: " + finalScore);
                                        
                                    }
                                }
                                else if (die2.currentDieValue == die5.currentDieValue)
                                {
                                    die1.Roll();
                                    Console.WriteLine("Dice 1 rolled: " + die1.currentDieValue);

                                    die4.Roll();
                                    Console.WriteLine("Dice 4 rolled: " + die4.currentDieValue);

                                    die3.Roll();
                                    Console.WriteLine("Dice 3 rolled: " + die3.currentDieValue);
                                    //five of a kind
                                    if (die1.currentDieValue == die2.currentDieValue &&
                                        die1.currentDieValue == die3.currentDieValue &&
                                        die1.currentDieValue == die4.currentDieValue &&
                                        die1.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("5 OF A KIND!");
                                        finalScore = finalScore + 12;
                                        Console.WriteLine("Score is: " + finalScore);
                                        
                                    }

                                    //four of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die2.currentDieValue == die3.currentDieValue && die2.currentDieValue == die4.currentDieValue && die2.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("4 of a kind");
                                        finalScore = finalScore + 6;
                                        Console.WriteLine("Score is: " + finalScore);
                                        
                                    }
                                    //three of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue ||
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
                                        Console.WriteLine("Score is: " + finalScore);
                                        
                                    }
                                }
                                else if (die3.currentDieValue == die4.currentDieValue)
                                {
                                    die1.Roll();
                                    Console.WriteLine("Dice 1 rolled: " + die1.currentDieValue);

                                    die2.Roll();
                                    Console.WriteLine("Dice 2 rolled: " + die2.currentDieValue);

                                    die5.Roll();
                                    Console.WriteLine("Dice 5 rolled: " + die5.currentDieValue);
                                    //five of a kind
                                    if (die1.currentDieValue == die2.currentDieValue &&
                                        die1.currentDieValue == die3.currentDieValue &&
                                        die1.currentDieValue == die4.currentDieValue &&
                                        die1.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("5 OF A KIND!");
                                        finalScore = finalScore + 12;
                                        Console.WriteLine("Score is: " + finalScore);
                                        
                                    }

                                    //four of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die2.currentDieValue == die3.currentDieValue && die2.currentDieValue == die4.currentDieValue && die2.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("4 of a kind");
                                        finalScore = finalScore + 6;
                                        Console.WriteLine("Score is: " + finalScore);
                                        
                                    }
                                    //three of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue ||
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
                                        Console.WriteLine("Score is: " + finalScore);
                                        
                                    }
                                }
                                else if (die3.currentDieValue == die5.currentDieValue)
                                {
                                    die1.Roll();
                                    Console.WriteLine("Dice 1 rolled: " + die1.currentDieValue);

                                    die2.Roll();
                                    Console.WriteLine("Dice 2 rolled: " + die2.currentDieValue);

                                    die4.Roll();
                                    Console.WriteLine("Dice 4 rolled: " + die4.currentDieValue);
                                    //five of a kind
                                    if (die1.currentDieValue == die2.currentDieValue &&
                                        die1.currentDieValue == die3.currentDieValue &&
                                        die1.currentDieValue == die4.currentDieValue &&
                                        die1.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("5 OF A KIND!");
                                        finalScore = finalScore + 12;
                                        Console.WriteLine("Score is: " + finalScore);
                                        
                                    }

                                    //four of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die2.currentDieValue == die3.currentDieValue && die2.currentDieValue == die4.currentDieValue && die2.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("4 of a kind");
                                        finalScore = finalScore + 6;
                                        Console.WriteLine("Score is: " + finalScore);
                                        
                                    }
                                    //three of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue ||
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
                                        Console.WriteLine("Score is: " + finalScore);
                                        
                                    }
                                }
                                else if (die5.currentDieValue == die4.currentDieValue)
                                {
                                    die1.Roll();
                                    Console.WriteLine("Dice 1 rolled: " + die1.currentDieValue);

                                    die2.Roll();
                                    Console.WriteLine("Dice 2 rolled: " + die2.currentDieValue);

                                    die3.Roll();
                                    Console.WriteLine("Dice 3 rolled: " + die3.currentDieValue);
                                    //five of a kind
                                    if (die1.currentDieValue == die2.currentDieValue &&
                                        die1.currentDieValue == die3.currentDieValue &&
                                        die1.currentDieValue == die4.currentDieValue &&
                                        die1.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("5 OF A KIND!");
                                        finalScore = finalScore + 12;
                                        Console.WriteLine("Score is: " + finalScore);
                                        
                                    }

                                    //four of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die2.currentDieValue == die3.currentDieValue && die2.currentDieValue == die4.currentDieValue && die2.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("4 of a kind");
                                        finalScore = finalScore + 6;
                                        Console.WriteLine("Score is: " + finalScore);
                                        
                                    }
                                    //three of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue ||
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
                                        Console.WriteLine("Score is: " + finalScore);
                                        
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Unlucky no roll");
                                    
                                }
                            }
                            else if (randomNum == 2)
                            {
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
                                    Console.WriteLine("Score is: " + finalScore);
                                }

                                else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue ||
                                    die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                    die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                    die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                    die2.currentDieValue == die3.currentDieValue && die2.currentDieValue == die4.currentDieValue && die2.currentDieValue == die5.currentDieValue)
                                {
                                    Console.WriteLine("4 of a kind");
                                    finalScore = finalScore + 6;
                                    Console.WriteLine("Score is: " + finalScore);
                                }

                                else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue ||
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
                                    Console.WriteLine("Score is: " + finalScore);
                                }

                                else
                                {
                                    Console.WriteLine("Unlucky no roll");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Input not valid");                                     //Code stops if invalid input is entered
                                break;
                            }


                        }
                        else
                        {
                            Console.WriteLine("Unlucky no roll");
                        }
                        Console.WriteLine("Players Turn");

                        die1.Roll();                                                                       //Code to roll all die for player
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
                            finalScore = finalScore2 + 12;
                            Console.WriteLine("Score is: " + finalScore2);

                        }

                        //4 of a kind
                        else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue ||
                            die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                            die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                            die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                            die2.currentDieValue == die3.currentDieValue && die2.currentDieValue == die4.currentDieValue && die2.currentDieValue == die5.currentDieValue)
                        {
                            Console.WriteLine("4 of a kind");
                            finalScore2 = finalScore2 + 6;
                            Console.WriteLine("Score is: " + finalScore2);
                        }

                        //3 of a kind
                        else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue ||
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
                            finalScore2 = finalScore2 + 3;
                            Console.WriteLine("Score is: " + finalScore2);

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

                                    //five of a kind
                                    if (die1.currentDieValue == die2.currentDieValue &&
                                        die1.currentDieValue == die3.currentDieValue &&
                                        die1.currentDieValue == die4.currentDieValue &&
                                        die1.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("5 OF A KIND!");
                                        finalScore2 = finalScore2 + 12;
                                        Console.WriteLine("Score is: " + finalScore2);
                                    }

                                    //four of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die2.currentDieValue == die3.currentDieValue && die2.currentDieValue == die4.currentDieValue && die2.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("4 of a kind");
                                        finalScore2 = finalScore2 + 6;
                                        Console.WriteLine("Score is: " + finalScore2);
                                    }
                                    //three of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue ||
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
                                        finalScore2 = finalScore2 + 3;
                                        Console.WriteLine("Score is: " + finalScore2);

                                    }
                                }
                                else if (die1.currentDieValue == die3.currentDieValue)
                                {
                                    die2.Roll();
                                    Console.WriteLine("Dice 2 rolled: " + die2.currentDieValue);

                                    die4.Roll();
                                    Console.WriteLine("Dice 4 rolled: " + die4.currentDieValue);

                                    die5.Roll();
                                    Console.WriteLine("Dice 5 rolled: " + die5.currentDieValue);
                                    //five of a kind
                                    if (die1.currentDieValue == die2.currentDieValue &&
                                        die1.currentDieValue == die3.currentDieValue &&
                                        die1.currentDieValue == die4.currentDieValue &&
                                        die1.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("5 OF A KIND!");
                                        finalScore2 = finalScore2 + 12;
                                        Console.WriteLine("Score is: " + finalScore2);

                                    }

                                    //four of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die2.currentDieValue == die3.currentDieValue && die2.currentDieValue == die4.currentDieValue && die2.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("4 of a kind");
                                        finalScore2 = finalScore2 + 6;
                                        Console.WriteLine("Score is: " + finalScore2);

                                    }
                                    //three of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue ||
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
                                        finalScore2 = finalScore2 + 3;
                                        Console.WriteLine("Score is: " + finalScore2);

                                    }
                                }
                                else if (die1.currentDieValue == die4.currentDieValue)
                                {
                                    die2.Roll();
                                    Console.WriteLine("Dice 2 rolled: " + die2.currentDieValue);

                                    die3.Roll();
                                    Console.WriteLine("Dice 3 rolled: " + die3.currentDieValue);

                                    die5.Roll();
                                    Console.WriteLine("Dice 5 rolled: " + die5.currentDieValue);
                                    //five of a kind
                                    if (die1.currentDieValue == die2.currentDieValue &&
                                        die1.currentDieValue == die3.currentDieValue &&
                                        die1.currentDieValue == die4.currentDieValue &&
                                        die1.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("5 OF A KIND!");
                                        finalScore2 = finalScore2 + 12;
                                        Console.WriteLine("Score is: " + finalScore2);

                                    }

                                    //four of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die2.currentDieValue == die3.currentDieValue && die2.currentDieValue == die4.currentDieValue && die2.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("4 of a kind");
                                        finalScore2 = finalScore2 + 6;
                                        Console.WriteLine("Score is: " + finalScore2);

                                    }
                                    //three of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue ||
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
                                        finalScore2 = finalScore2 + 3;
                                        Console.WriteLine("Score is: " + finalScore2);

                                    }

                                }
                                else if (die1.currentDieValue == die5.currentDieValue)
                                {
                                    die2.Roll();
                                    Console.WriteLine("Dice 2 rolled: " + die2.currentDieValue);

                                    die3.Roll();
                                    Console.WriteLine("Dice 3 rolled: " + die3.currentDieValue);

                                    die4.Roll();
                                    Console.WriteLine("Dice 4 rolled: " + die4.currentDieValue);
                                    //five of a kind
                                    if (die1.currentDieValue == die2.currentDieValue &&
                                        die1.currentDieValue == die3.currentDieValue &&
                                        die1.currentDieValue == die4.currentDieValue &&
                                        die1.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("5 OF A KIND!");
                                        finalScore2 = finalScore2 + 12;
                                        Console.WriteLine("Score is: " + finalScore2);

                                    }

                                    //four of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die2.currentDieValue == die3.currentDieValue && die2.currentDieValue == die4.currentDieValue && die2.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("4 of a kind");
                                        finalScore2 = finalScore2 + 6;
                                        Console.WriteLine("Score is: " + finalScore2);

                                    }
                                    //three of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue ||
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
                                        finalScore2 = finalScore2 + 3;
                                        Console.WriteLine("Score is: " + finalScore2);

                                    }
                                }
                                else if (die2.currentDieValue == die3.currentDieValue)
                                {
                                    die1.Roll();
                                    Console.WriteLine("Dice 1 rolled: " + die1.currentDieValue);

                                    die4.Roll();
                                    Console.WriteLine("Dice 4 rolled: " + die4.currentDieValue);

                                    die5.Roll();
                                    Console.WriteLine("Dice 5 rolled: " + die5.currentDieValue);
                                    //five of a kind
                                    if (die1.currentDieValue == die2.currentDieValue &&
                                        die1.currentDieValue == die3.currentDieValue &&
                                        die1.currentDieValue == die4.currentDieValue &&
                                        die1.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("5 OF A KIND!");
                                        finalScore2 = finalScore2 + 12;
                                        Console.WriteLine("Score is: " + finalScore2);

                                    }

                                    //four of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die2.currentDieValue == die3.currentDieValue && die2.currentDieValue == die4.currentDieValue && die2.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("4 of a kind");
                                        finalScore2 = finalScore2 + 6;
                                        Console.WriteLine("Score is: " + finalScore2);

                                    }
                                    //three of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue ||
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
                                        finalScore2 = finalScore2 + 3;
                                        Console.WriteLine("Score is: " + finalScore2);

                                    }
                                }
                                else if (die2.currentDieValue == die4.currentDieValue)
                                {
                                    die1.Roll();
                                    Console.WriteLine("Dice 1 rolled: " + die1.currentDieValue);

                                    die3.Roll();
                                    Console.WriteLine("Dice 3 rolled: " + die3.currentDieValue);

                                    die5.Roll();
                                    Console.WriteLine("Dice 5 rolled: " + die5.currentDieValue);
                                    //five of a kind
                                    if (die1.currentDieValue == die2.currentDieValue &&
                                        die1.currentDieValue == die3.currentDieValue &&
                                        die1.currentDieValue == die4.currentDieValue &&
                                        die1.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("5 OF A KIND!");
                                        finalScore2 = finalScore2 + 12;
                                        Console.WriteLine("Score is: " + finalScore2);

                                    }

                                    //four of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die2.currentDieValue == die3.currentDieValue && die2.currentDieValue == die4.currentDieValue && die2.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("4 of a kind");
                                        finalScore2 = finalScore2 + 6;
                                        Console.WriteLine("Score is: " + finalScore2);

                                    }
                                    //three of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue ||
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
                                        finalScore2 = finalScore2 + 3;
                                        Console.WriteLine("Score is: " + finalScore2);

                                    }
                                }
                                else if (die2.currentDieValue == die5.currentDieValue)
                                {
                                    die1.Roll();
                                    Console.WriteLine("Dice 1 rolled: " + die1.currentDieValue);

                                    die4.Roll();
                                    Console.WriteLine("Dice 4 rolled: " + die4.currentDieValue);

                                    die3.Roll();
                                    Console.WriteLine("Dice 3 rolled: " + die3.currentDieValue);
                                    //five of a kind
                                    if (die1.currentDieValue == die2.currentDieValue &&
                                        die1.currentDieValue == die3.currentDieValue &&
                                        die1.currentDieValue == die4.currentDieValue &&
                                        die1.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("5 OF A KIND!");
                                        finalScore2 = finalScore2 + 12;
                                        Console.WriteLine("Score is: " + finalScore2);

                                    }

                                    //four of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die2.currentDieValue == die3.currentDieValue && die2.currentDieValue == die4.currentDieValue && die2.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("4 of a kind");
                                        finalScore2 = finalScore2 + 6;
                                        Console.WriteLine("Score is: " + finalScore2);

                                    }
                                    //three of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue ||
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
                                        finalScore2 = finalScore2 + 3;
                                        Console.WriteLine("Score is: " + finalScore2);

                                    }
                                }
                                else if (die3.currentDieValue == die4.currentDieValue)
                                {
                                    die1.Roll();
                                    Console.WriteLine("Dice 1 rolled: " + die1.currentDieValue);

                                    die2.Roll();
                                    Console.WriteLine("Dice 2 rolled: " + die2.currentDieValue);

                                    die5.Roll();
                                    Console.WriteLine("Dice 5 rolled: " + die5.currentDieValue);
                                    //five of a kind
                                    if (die1.currentDieValue == die2.currentDieValue &&
                                        die1.currentDieValue == die3.currentDieValue &&
                                        die1.currentDieValue == die4.currentDieValue &&
                                        die1.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("5 OF A KIND!");
                                        finalScore2 = finalScore2 + 12;
                                        Console.WriteLine("Score is: " + finalScore2);

                                    }

                                    //four of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die2.currentDieValue == die3.currentDieValue && die2.currentDieValue == die4.currentDieValue && die2.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("4 of a kind");
                                        finalScore2 = finalScore2 + 6;
                                        Console.WriteLine("Score is: " + finalScore2);

                                    }
                                    //three of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue ||
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
                                        finalScore2 = finalScore2 + 3;
                                        Console.WriteLine("Score is: " + finalScore2);

                                    }
                                }
                                else if (die3.currentDieValue == die5.currentDieValue)
                                {
                                    die1.Roll();
                                    Console.WriteLine("Dice 1 rolled: " + die1.currentDieValue);

                                    die2.Roll();
                                    Console.WriteLine("Dice 2 rolled: " + die2.currentDieValue);

                                    die4.Roll();
                                    Console.WriteLine("Dice 4 rolled: " + die4.currentDieValue);
                                    //five of a kind
                                    if (die1.currentDieValue == die2.currentDieValue &&
                                        die1.currentDieValue == die3.currentDieValue &&
                                        die1.currentDieValue == die4.currentDieValue &&
                                        die1.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("5 OF A KIND!");
                                        finalScore2 = finalScore2 + 12;
                                        Console.WriteLine("Score is: " + finalScore2);

                                    }

                                    //four of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die2.currentDieValue == die3.currentDieValue && die2.currentDieValue == die4.currentDieValue && die2.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("4 of a kind");
                                        finalScore2 = finalScore2 + 6;
                                        Console.WriteLine("Score is: " + finalScore2);

                                    }
                                    //three of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue ||
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
                                        finalScore2 = finalScore2 + 3;
                                        Console.WriteLine("Score is: " + finalScore2);

                                    }
                                }
                                else if (die5.currentDieValue == die4.currentDieValue)
                                {
                                    die1.Roll();
                                    Console.WriteLine("Dice 1 rolled: " + die1.currentDieValue);

                                    die2.Roll();
                                    Console.WriteLine("Dice 2 rolled: " + die2.currentDieValue);

                                    die3.Roll();
                                    Console.WriteLine("Dice 3 rolled: " + die3.currentDieValue);
                                    //five of a kind
                                    if (die1.currentDieValue == die2.currentDieValue &&
                                        die1.currentDieValue == die3.currentDieValue &&
                                        die1.currentDieValue == die4.currentDieValue &&
                                        die1.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("5 OF A KIND!");
                                        finalScore2 = finalScore2 + 12;
                                        Console.WriteLine("Score is: " + finalScore2);

                                    }

                                    //four of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die2.currentDieValue == die3.currentDieValue && die2.currentDieValue == die4.currentDieValue && die2.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("4 of a kind");
                                        finalScore2 = finalScore2 + 6;
                                        Console.WriteLine("Score is: " + finalScore2);

                                    }
                                    //three of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue ||
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
                                        finalScore2 = finalScore2 + 3;
                                        Console.WriteLine("Score is: " + finalScore2);

                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Unlucky no roll");

                                }
                            }
                            else if (userinput == "2")
                            {
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
                                    finalScore2 = finalScore2 + 12;
                                    Console.WriteLine("Score is: " + finalScore2);

                                }

                                else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue ||
                                    die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                    die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                    die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                    die2.currentDieValue == die3.currentDieValue && die2.currentDieValue == die4.currentDieValue && die2.currentDieValue == die5.currentDieValue)
                                {
                                    Console.WriteLine("4 of a kind");
                                    finalScore2 = finalScore2 + 6;
                                    Console.WriteLine("Score is: " + finalScore2);

                                }

                                else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue ||
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
                                    finalScore2 = finalScore2 + 3;
                                    Console.WriteLine("Score is: " + finalScore2);

                                }

                                else
                                {
                                    Console.WriteLine("Unlucky no roll");

                                }
                            }
                            else
                            {
                                Console.WriteLine("Input not valid");
                                break;
                            }


                        }
                        else
                        {
                            Console.WriteLine("Unlucky no roll");
                        }
                    }
                    Console.WriteLine("GAME IS OVER");                                                                       //when the game is over final score is displayed
                    Console.WriteLine("Computer got: " + finalScore + "player got: " + finalScore2);
                }

                else if (userInput == "2")                                                                                   //Same exact code except for one difference
                {
                    Console.WriteLine("Playing against player");
                    int finalScore = 0;
                    int finalScore2 = 0;

                    while (finalScore <= 20 || finalScore2 <= 20)
                    {
                        Die die1 = new Die();
                        Die die2 = new Die();
                        Die die3 = new Die();
                        Die die4 = new Die();
                        Die die5 = new Die();

                        Console.WriteLine("Player 1 turn");

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
                            Console.WriteLine("Score is: " + finalScore);

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
                            Console.WriteLine("Score is: " + finalScore);

                        }

                        //3 of a kind
                        else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue ||
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
                            Console.WriteLine("Score is: " + finalScore);
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
                            Console.WriteLine("You can either\nthow the remaining dice [1]\n Throw all of them [2].\n Please pick one of the two options\n[1]/[2]");                  //Allows for players to choose what option they want
                            string userinput = Console.ReadLine();                                                                                                                    //Also in the other game for player
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

                                    //five of a kind
                                    if (die1.currentDieValue == die2.currentDieValue &&
                                        die1.currentDieValue == die3.currentDieValue &&
                                        die1.currentDieValue == die4.currentDieValue &&
                                        die1.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("5 OF A KIND!");
                                        finalScore = finalScore + 12;
                                        Console.WriteLine("Score is: " + finalScore);

                                    }

                                    //four of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die2.currentDieValue == die3.currentDieValue && die2.currentDieValue == die4.currentDieValue && die2.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("4 of a kind");
                                        finalScore = finalScore + 6;
                                        Console.WriteLine("Score is: " + finalScore);

                                    }
                                    //three of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue ||
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
                                        Console.WriteLine("Score is: " + finalScore);

                                    }
                                }
                                else if (die1.currentDieValue == die3.currentDieValue)
                                {
                                    die2.Roll();
                                    Console.WriteLine("Dice 2 rolled: " + die2.currentDieValue);

                                    die4.Roll();
                                    Console.WriteLine("Dice 4 rolled: " + die4.currentDieValue);

                                    die5.Roll();
                                    Console.WriteLine("Dice 5 rolled: " + die5.currentDieValue);
                                    //five of a kind
                                    if (die1.currentDieValue == die2.currentDieValue &&
                                        die1.currentDieValue == die3.currentDieValue &&
                                        die1.currentDieValue == die4.currentDieValue &&
                                        die1.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("5 OF A KIND!");
                                        finalScore = finalScore + 12;
                                        Console.WriteLine("Score is: " + finalScore);

                                    }

                                    //four of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die2.currentDieValue == die3.currentDieValue && die2.currentDieValue == die4.currentDieValue && die2.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("4 of a kind");
                                        finalScore = finalScore + 6;
                                        Console.WriteLine("Score is: " + finalScore);

                                    }
                                    //three of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue ||
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
                                        Console.WriteLine("Score is: " + finalScore);

                                    }
                                }
                                else if (die1.currentDieValue == die4.currentDieValue)
                                {
                                    die2.Roll();
                                    Console.WriteLine("Dice 2 rolled: " + die2.currentDieValue);

                                    die3.Roll();
                                    Console.WriteLine("Dice 3 rolled: " + die3.currentDieValue);

                                    die5.Roll();
                                    Console.WriteLine("Dice 5 rolled: " + die5.currentDieValue);
                                    //five of a kind
                                    if (die1.currentDieValue == die2.currentDieValue &&
                                        die1.currentDieValue == die3.currentDieValue &&
                                        die1.currentDieValue == die4.currentDieValue &&
                                        die1.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("5 OF A KIND!");
                                        finalScore = finalScore + 12;
                                        Console.WriteLine("Score is: " + finalScore);

                                    }

                                    //four of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die2.currentDieValue == die3.currentDieValue && die2.currentDieValue == die4.currentDieValue && die2.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("4 of a kind");
                                        finalScore = finalScore + 6;
                                        Console.WriteLine("Score is: " + finalScore);

                                    }
                                    //three of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue ||
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
                                        Console.WriteLine("Score is: " + finalScore);

                                    }

                                }
                                else if (die1.currentDieValue == die5.currentDieValue)
                                {
                                    die2.Roll();
                                    Console.WriteLine("Dice 2 rolled: " + die2.currentDieValue);

                                    die3.Roll();
                                    Console.WriteLine("Dice 3 rolled: " + die3.currentDieValue);

                                    die4.Roll();
                                    Console.WriteLine("Dice 4 rolled: " + die4.currentDieValue);
                                    //five of a kind
                                    if (die1.currentDieValue == die2.currentDieValue &&
                                        die1.currentDieValue == die3.currentDieValue &&
                                        die1.currentDieValue == die4.currentDieValue &&
                                        die1.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("5 OF A KIND!");
                                        finalScore = finalScore + 12;
                                        Console.WriteLine("Score is: " + finalScore);

                                    }

                                    //four of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die2.currentDieValue == die3.currentDieValue && die2.currentDieValue == die4.currentDieValue && die2.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("4 of a kind");
                                        finalScore = finalScore + 6;
                                        Console.WriteLine("Score is: " + finalScore);

                                    }
                                    //three of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue ||
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
                                        Console.WriteLine("Score is: " + finalScore);

                                    }
                                }
                                else if (die2.currentDieValue == die3.currentDieValue)
                                {
                                    die1.Roll();
                                    Console.WriteLine("Dice 1 rolled: " + die1.currentDieValue);

                                    die4.Roll();
                                    Console.WriteLine("Dice 4 rolled: " + die4.currentDieValue);

                                    die5.Roll();
                                    Console.WriteLine("Dice 5 rolled: " + die5.currentDieValue);
                                    //five of a kind
                                    if (die1.currentDieValue == die2.currentDieValue &&
                                        die1.currentDieValue == die3.currentDieValue &&
                                        die1.currentDieValue == die4.currentDieValue &&
                                        die1.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("5 OF A KIND!");
                                        finalScore = finalScore + 12;
                                        Console.WriteLine("Score is: " + finalScore);

                                    }

                                    //four of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die2.currentDieValue == die3.currentDieValue && die2.currentDieValue == die4.currentDieValue && die2.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("4 of a kind");
                                        finalScore = finalScore + 6;
                                        Console.WriteLine("Score is: " + finalScore);

                                    }
                                    //three of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue ||
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
                                        Console.WriteLine("Score is: " + finalScore);

                                    }
                                }
                                else if (die2.currentDieValue == die4.currentDieValue)
                                {
                                    die1.Roll();
                                    Console.WriteLine("Dice 1 rolled: " + die1.currentDieValue);

                                    die3.Roll();
                                    Console.WriteLine("Dice 3 rolled: " + die3.currentDieValue);

                                    die5.Roll();
                                    Console.WriteLine("Dice 5 rolled: " + die5.currentDieValue);
                                    //five of a kind
                                    if (die1.currentDieValue == die2.currentDieValue &&
                                        die1.currentDieValue == die3.currentDieValue &&
                                        die1.currentDieValue == die4.currentDieValue &&
                                        die1.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("5 OF A KIND!");
                                        finalScore = finalScore + 12;
                                        Console.WriteLine("Score is: " + finalScore);

                                    }

                                    //four of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die2.currentDieValue == die3.currentDieValue && die2.currentDieValue == die4.currentDieValue && die2.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("4 of a kind");
                                        finalScore = finalScore + 6;
                                        Console.WriteLine("Score is: " + finalScore);

                                    }
                                    //three of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue ||
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
                                        Console.WriteLine("Score is: " + finalScore);

                                    }
                                }
                                else if (die2.currentDieValue == die5.currentDieValue)
                                {
                                    die1.Roll();
                                    Console.WriteLine("Dice 1 rolled: " + die1.currentDieValue);

                                    die4.Roll();
                                    Console.WriteLine("Dice 4 rolled: " + die4.currentDieValue);

                                    die3.Roll();
                                    Console.WriteLine("Dice 3 rolled: " + die3.currentDieValue);
                                    //five of a kind
                                    if (die1.currentDieValue == die2.currentDieValue &&
                                        die1.currentDieValue == die3.currentDieValue &&
                                        die1.currentDieValue == die4.currentDieValue &&
                                        die1.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("5 OF A KIND!");
                                        finalScore = finalScore + 12;
                                        Console.WriteLine("Score is: " + finalScore);

                                    }

                                    //four of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die2.currentDieValue == die3.currentDieValue && die2.currentDieValue == die4.currentDieValue && die2.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("4 of a kind");
                                        finalScore = finalScore + 6;
                                        Console.WriteLine("Score is: " + finalScore);

                                    }
                                    //three of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue ||
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
                                        Console.WriteLine("Score is: " + finalScore);

                                    }
                                }
                                else if (die3.currentDieValue == die4.currentDieValue)
                                {
                                    die1.Roll();
                                    Console.WriteLine("Dice 1 rolled: " + die1.currentDieValue);

                                    die2.Roll();
                                    Console.WriteLine("Dice 2 rolled: " + die2.currentDieValue);

                                    die5.Roll();
                                    Console.WriteLine("Dice 5 rolled: " + die5.currentDieValue);
                                    //five of a kind
                                    if (die1.currentDieValue == die2.currentDieValue &&
                                        die1.currentDieValue == die3.currentDieValue &&
                                        die1.currentDieValue == die4.currentDieValue &&
                                        die1.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("5 OF A KIND!");
                                        finalScore = finalScore + 12;
                                        Console.WriteLine("Score is: " + finalScore);

                                    }

                                    //four of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die2.currentDieValue == die3.currentDieValue && die2.currentDieValue == die4.currentDieValue && die2.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("4 of a kind");
                                        finalScore = finalScore + 6;
                                        Console.WriteLine("Score is: " + finalScore);

                                    }
                                    //three of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue ||
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
                                        Console.WriteLine("Score is: " + finalScore);

                                    }
                                }
                                else if (die3.currentDieValue == die5.currentDieValue)
                                {
                                    die1.Roll();
                                    Console.WriteLine("Dice 1 rolled: " + die1.currentDieValue);

                                    die2.Roll();
                                    Console.WriteLine("Dice 2 rolled: " + die2.currentDieValue);

                                    die4.Roll();
                                    Console.WriteLine("Dice 4 rolled: " + die4.currentDieValue);
                                    //five of a kind
                                    if (die1.currentDieValue == die2.currentDieValue &&
                                        die1.currentDieValue == die3.currentDieValue &&
                                        die1.currentDieValue == die4.currentDieValue &&
                                        die1.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("5 OF A KIND!");
                                        finalScore = finalScore + 12;
                                        Console.WriteLine("Score is: " + finalScore);

                                    }

                                    //four of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die2.currentDieValue == die3.currentDieValue && die2.currentDieValue == die4.currentDieValue && die2.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("4 of a kind");
                                        finalScore = finalScore + 6;
                                        Console.WriteLine("Score is: " + finalScore);

                                    }
                                    //three of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue ||
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
                                        Console.WriteLine("Score is: " + finalScore);

                                    }
                                }
                                else if (die5.currentDieValue == die4.currentDieValue)
                                {
                                    die1.Roll();
                                    Console.WriteLine("Dice 1 rolled: " + die1.currentDieValue);

                                    die2.Roll();
                                    Console.WriteLine("Dice 2 rolled: " + die2.currentDieValue);

                                    die3.Roll();
                                    Console.WriteLine("Dice 3 rolled: " + die3.currentDieValue);
                                    //five of a kind
                                    if (die1.currentDieValue == die2.currentDieValue &&
                                        die1.currentDieValue == die3.currentDieValue &&
                                        die1.currentDieValue == die4.currentDieValue &&
                                        die1.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("5 OF A KIND!");
                                        finalScore = finalScore + 12;
                                        Console.WriteLine("Score is: " + finalScore);

                                    }

                                    //four of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die2.currentDieValue == die3.currentDieValue && die2.currentDieValue == die4.currentDieValue && die2.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("4 of a kind");
                                        finalScore = finalScore + 6;
                                        Console.WriteLine("Score is: " + finalScore);

                                    }
                                    //three of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue ||
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
                                        Console.WriteLine("Score is: " + finalScore);

                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Unlucky no roll");

                                }
                            }
                            else if (userinput == "2")
                            {
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
                                    Console.WriteLine("Score is: " + finalScore);
                                }

                                else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue ||
                                    die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                    die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                    die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                    die2.currentDieValue == die3.currentDieValue && die2.currentDieValue == die4.currentDieValue && die2.currentDieValue == die5.currentDieValue)
                                {
                                    Console.WriteLine("4 of a kind");
                                    finalScore = finalScore + 6;
                                    Console.WriteLine("Score is: " + finalScore);
                                }

                                else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue ||
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
                                    Console.WriteLine("Score is: " + finalScore);
                                }

                                else
                                {
                                    Console.WriteLine("Unlucky no roll");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Input not valid");
                                break;
                            }


                        }
                        else
                        {
                            Console.WriteLine("Unlucky no roll");
                        }
                        Console.WriteLine("Player 2 Turn");
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
                            finalScore = finalScore2 + 12;
                            Console.WriteLine("Score is: " + finalScore2);

                        }

                        //4 of a kind
                        else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue ||
                            die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                            die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                            die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                            die2.currentDieValue == die3.currentDieValue && die2.currentDieValue == die4.currentDieValue && die2.currentDieValue == die5.currentDieValue)
                        {
                            Console.WriteLine("4 of a kind");
                            finalScore2 = finalScore2 + 6;
                            Console.WriteLine("Score is: " + finalScore2);
                        }

                        //3 of a kind
                        else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue ||
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
                            finalScore2 = finalScore2 + 3;
                            Console.WriteLine("Score is: " + finalScore2);

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

                                    //five of a kind
                                    if (die1.currentDieValue == die2.currentDieValue &&
                                        die1.currentDieValue == die3.currentDieValue &&
                                        die1.currentDieValue == die4.currentDieValue &&
                                        die1.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("5 OF A KIND!");
                                        finalScore2 = finalScore2 + 12;
                                        Console.WriteLine("Score is: " + finalScore2);
                                    }

                                    //four of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die2.currentDieValue == die3.currentDieValue && die2.currentDieValue == die4.currentDieValue && die2.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("4 of a kind");
                                        finalScore2 = finalScore2 + 6;
                                        Console.WriteLine("Score is: " + finalScore2);
                                    }
                                    //three of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue ||
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
                                        finalScore2 = finalScore2 + 3;
                                        Console.WriteLine("Score is: " + finalScore2);

                                    }
                                }
                                else if (die1.currentDieValue == die3.currentDieValue)
                                {
                                    die2.Roll();
                                    Console.WriteLine("Dice 2 rolled: " + die2.currentDieValue);

                                    die4.Roll();
                                    Console.WriteLine("Dice 4 rolled: " + die4.currentDieValue);

                                    die5.Roll();
                                    Console.WriteLine("Dice 5 rolled: " + die5.currentDieValue);
                                    //five of a kind
                                    if (die1.currentDieValue == die2.currentDieValue &&
                                        die1.currentDieValue == die3.currentDieValue &&
                                        die1.currentDieValue == die4.currentDieValue &&
                                        die1.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("5 OF A KIND!");
                                        finalScore2 = finalScore2 + 12;
                                        Console.WriteLine("Score is: " + finalScore2);

                                    }

                                    //four of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die2.currentDieValue == die3.currentDieValue && die2.currentDieValue == die4.currentDieValue && die2.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("4 of a kind");
                                        finalScore2 = finalScore2 + 6;
                                        Console.WriteLine("Score is: " + finalScore2);

                                    }
                                    //three of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue ||
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
                                        finalScore2 = finalScore2 + 3;
                                        Console.WriteLine("Score is: " + finalScore2);

                                    }
                                }
                                else if (die1.currentDieValue == die4.currentDieValue)
                                {
                                    die2.Roll();
                                    Console.WriteLine("Dice 2 rolled: " + die2.currentDieValue);

                                    die3.Roll();
                                    Console.WriteLine("Dice 3 rolled: " + die3.currentDieValue);

                                    die5.Roll();
                                    Console.WriteLine("Dice 5 rolled: " + die5.currentDieValue);
                                    //five of a kind
                                    if (die1.currentDieValue == die2.currentDieValue &&
                                        die1.currentDieValue == die3.currentDieValue &&
                                        die1.currentDieValue == die4.currentDieValue &&
                                        die1.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("5 OF A KIND!");
                                        finalScore2 = finalScore2 + 12;
                                        Console.WriteLine("Score is: " + finalScore2);

                                    }

                                    //four of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die2.currentDieValue == die3.currentDieValue && die2.currentDieValue == die4.currentDieValue && die2.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("4 of a kind");
                                        finalScore2 = finalScore2 + 6;
                                        Console.WriteLine("Score is: " + finalScore2);

                                    }
                                    //three of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue ||
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
                                        finalScore2 = finalScore2 + 3;
                                        Console.WriteLine("Score is: " + finalScore2);

                                    }

                                }
                                else if (die1.currentDieValue == die5.currentDieValue)
                                {
                                    die2.Roll();
                                    Console.WriteLine("Dice 2 rolled: " + die2.currentDieValue);

                                    die3.Roll();
                                    Console.WriteLine("Dice 3 rolled: " + die3.currentDieValue);

                                    die4.Roll();
                                    Console.WriteLine("Dice 4 rolled: " + die4.currentDieValue);
                                    //five of a kind
                                    if (die1.currentDieValue == die2.currentDieValue &&
                                        die1.currentDieValue == die3.currentDieValue &&
                                        die1.currentDieValue == die4.currentDieValue &&
                                        die1.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("5 OF A KIND!");
                                        finalScore2 = finalScore2 + 12;
                                        Console.WriteLine("Score is: " + finalScore2);

                                    }

                                    //four of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die2.currentDieValue == die3.currentDieValue && die2.currentDieValue == die4.currentDieValue && die2.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("4 of a kind");
                                        finalScore2 = finalScore2 + 6;
                                        Console.WriteLine("Score is: " + finalScore2);

                                    }
                                    //three of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue ||
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
                                        finalScore2 = finalScore2 + 3;
                                        Console.WriteLine("Score is: " + finalScore2);

                                    }
                                }
                                else if (die2.currentDieValue == die3.currentDieValue)
                                {
                                    die1.Roll();
                                    Console.WriteLine("Dice 1 rolled: " + die1.currentDieValue);

                                    die4.Roll();
                                    Console.WriteLine("Dice 4 rolled: " + die4.currentDieValue);

                                    die5.Roll();
                                    Console.WriteLine("Dice 5 rolled: " + die5.currentDieValue);
                                    //five of a kind
                                    if (die1.currentDieValue == die2.currentDieValue &&
                                        die1.currentDieValue == die3.currentDieValue &&
                                        die1.currentDieValue == die4.currentDieValue &&
                                        die1.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("5 OF A KIND!");
                                        finalScore2 = finalScore2 + 12;
                                        Console.WriteLine("Score is: " + finalScore2);

                                    }

                                    //four of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die2.currentDieValue == die3.currentDieValue && die2.currentDieValue == die4.currentDieValue && die2.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("4 of a kind");
                                        finalScore2 = finalScore2 + 6;
                                        Console.WriteLine("Score is: " + finalScore2);

                                    }
                                    //three of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue ||
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
                                        finalScore2 = finalScore2 + 3;
                                        Console.WriteLine("Score is: " + finalScore2);

                                    }
                                }
                                else if (die2.currentDieValue == die4.currentDieValue)
                                {
                                    die1.Roll();
                                    Console.WriteLine("Dice 1 rolled: " + die1.currentDieValue);

                                    die3.Roll();
                                    Console.WriteLine("Dice 3 rolled: " + die3.currentDieValue);

                                    die5.Roll();
                                    Console.WriteLine("Dice 5 rolled: " + die5.currentDieValue);
                                    //five of a kind
                                    if (die1.currentDieValue == die2.currentDieValue &&
                                        die1.currentDieValue == die3.currentDieValue &&
                                        die1.currentDieValue == die4.currentDieValue &&
                                        die1.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("5 OF A KIND!");
                                        finalScore2 = finalScore2 + 12;
                                        Console.WriteLine("Score is: " + finalScore2);

                                    }

                                    //four of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die2.currentDieValue == die3.currentDieValue && die2.currentDieValue == die4.currentDieValue && die2.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("4 of a kind");
                                        finalScore2 = finalScore2 + 6;
                                        Console.WriteLine("Score is: " + finalScore2);

                                    }
                                    //three of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue ||
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
                                        finalScore2 = finalScore2 + 3;
                                        Console.WriteLine("Score is: " + finalScore2);

                                    }
                                }
                                else if (die2.currentDieValue == die5.currentDieValue)
                                {
                                    die1.Roll();
                                    Console.WriteLine("Dice 1 rolled: " + die1.currentDieValue);

                                    die4.Roll();
                                    Console.WriteLine("Dice 4 rolled: " + die4.currentDieValue);

                                    die3.Roll();
                                    Console.WriteLine("Dice 3 rolled: " + die3.currentDieValue);
                                    //five of a kind
                                    if (die1.currentDieValue == die2.currentDieValue &&
                                        die1.currentDieValue == die3.currentDieValue &&
                                        die1.currentDieValue == die4.currentDieValue &&
                                        die1.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("5 OF A KIND!");
                                        finalScore2 = finalScore2 + 12;
                                        Console.WriteLine("Score is: " + finalScore2);

                                    }

                                    //four of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die2.currentDieValue == die3.currentDieValue && die2.currentDieValue == die4.currentDieValue && die2.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("4 of a kind");
                                        finalScore2 = finalScore2 + 6;
                                        Console.WriteLine("Score is: " + finalScore2);

                                    }
                                    //three of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue ||
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
                                        finalScore2 = finalScore2 + 3;
                                        Console.WriteLine("Score is: " + finalScore2);

                                    }
                                }
                                else if (die3.currentDieValue == die4.currentDieValue)
                                {
                                    die1.Roll();
                                    Console.WriteLine("Dice 1 rolled: " + die1.currentDieValue);

                                    die2.Roll();
                                    Console.WriteLine("Dice 2 rolled: " + die2.currentDieValue);

                                    die5.Roll();
                                    Console.WriteLine("Dice 5 rolled: " + die5.currentDieValue);
                                    //five of a kind
                                    if (die1.currentDieValue == die2.currentDieValue &&
                                        die1.currentDieValue == die3.currentDieValue &&
                                        die1.currentDieValue == die4.currentDieValue &&
                                        die1.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("5 OF A KIND!");
                                        finalScore2 = finalScore2 + 12;
                                        Console.WriteLine("Score is: " + finalScore2);

                                    }

                                    //four of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die2.currentDieValue == die3.currentDieValue && die2.currentDieValue == die4.currentDieValue && die2.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("4 of a kind");
                                        finalScore2 = finalScore2 + 6;
                                        Console.WriteLine("Score is: " + finalScore2);

                                    }
                                    //three of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue ||
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
                                        finalScore2 = finalScore2 + 3;
                                        Console.WriteLine("Score is: " + finalScore2);

                                    }
                                }
                                else if (die3.currentDieValue == die5.currentDieValue)
                                {
                                    die1.Roll();
                                    Console.WriteLine("Dice 1 rolled: " + die1.currentDieValue);

                                    die2.Roll();
                                    Console.WriteLine("Dice 2 rolled: " + die2.currentDieValue);

                                    die4.Roll();
                                    Console.WriteLine("Dice 4 rolled: " + die4.currentDieValue);
                                    //five of a kind
                                    if (die1.currentDieValue == die2.currentDieValue &&
                                        die1.currentDieValue == die3.currentDieValue &&
                                        die1.currentDieValue == die4.currentDieValue &&
                                        die1.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("5 OF A KIND!");
                                        finalScore2 = finalScore2 + 12;
                                        Console.WriteLine("Score is: " + finalScore2);

                                    }

                                    //four of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die2.currentDieValue == die3.currentDieValue && die2.currentDieValue == die4.currentDieValue && die2.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("4 of a kind");
                                        finalScore2 = finalScore2 + 6;
                                        Console.WriteLine("Score is: " + finalScore2);

                                    }
                                    //three of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue ||
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
                                        finalScore2 = finalScore2 + 3;
                                        Console.WriteLine("Score is: " + finalScore2);

                                    }
                                }
                                else if (die5.currentDieValue == die4.currentDieValue)
                                {
                                    die1.Roll();
                                    Console.WriteLine("Dice 1 rolled: " + die1.currentDieValue);

                                    die2.Roll();
                                    Console.WriteLine("Dice 2 rolled: " + die2.currentDieValue);

                                    die3.Roll();
                                    Console.WriteLine("Dice 3 rolled: " + die3.currentDieValue);
                                    //five of a kind
                                    if (die1.currentDieValue == die2.currentDieValue &&
                                        die1.currentDieValue == die3.currentDieValue &&
                                        die1.currentDieValue == die4.currentDieValue &&
                                        die1.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("5 OF A KIND!");
                                        finalScore2 = finalScore2 + 12;
                                        Console.WriteLine("Score is: " + finalScore2);

                                    }

                                    //four of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                        die2.currentDieValue == die3.currentDieValue && die2.currentDieValue == die4.currentDieValue && die2.currentDieValue == die5.currentDieValue)
                                    {
                                        Console.WriteLine("4 of a kind");
                                        finalScore2 = finalScore2 + 6;
                                        Console.WriteLine("Score is: " + finalScore2);

                                    }
                                    //three of a kind
                                    else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue ||
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
                                        finalScore2 = finalScore2 + 3;
                                        Console.WriteLine("Score is: " + finalScore2);

                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Unlucky no roll");

                                }
                            }
                            else if (userinput == "2")
                            {
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
                                    finalScore2 = finalScore2 + 12;
                                    Console.WriteLine("Score is: " + finalScore2);

                                }

                                else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue ||
                                    die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                    die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                    die1.currentDieValue == die3.currentDieValue && die1.currentDieValue == die4.currentDieValue && die1.currentDieValue == die5.currentDieValue ||
                                    die2.currentDieValue == die3.currentDieValue && die2.currentDieValue == die4.currentDieValue && die2.currentDieValue == die5.currentDieValue)
                                {
                                    Console.WriteLine("4 of a kind");
                                    finalScore2 = finalScore2 + 6;
                                    Console.WriteLine("Score is: " + finalScore2);

                                }

                                else if (die1.currentDieValue == die2.currentDieValue && die1.currentDieValue == die3.currentDieValue ||
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
                                    finalScore2 = finalScore2 + 3;
                                    Console.WriteLine("Score is: " + finalScore2);

                                }

                                else
                                {
                                    Console.WriteLine("Unlucky no roll");

                                }
                            }
                            else
                            {
                                Console.WriteLine("Input not valid");
                                break;
                            }


                        }
                        else
                        {
                            Console.WriteLine("Unlucky no roll");
                        }
                    }




                    Console.WriteLine("GAME IS OVER");
                    Console.WriteLine("Computer got: " + finalScore + "player got: " + finalScore2);
                }

            } //end of code
        }
    }
}


