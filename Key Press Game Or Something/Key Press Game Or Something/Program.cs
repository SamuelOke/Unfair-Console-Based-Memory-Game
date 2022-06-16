using System;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;

namespace KeyPressGame
{
    class Program
    {
        static void newTimer(bool exit, string letter)
        {
            var rand = new Random();
            Console.WriteLine("Remember the letter: " + letter);
            for (int timer = rand.Next(0, 5); timer >= 0; timer--)
            { 
                Console.WriteLine("You have {0} seconds!", timer);
                System.Threading.Thread.Sleep(rand.Next(0, 501));
                
            }
        }
        
        static void Game()
        {
            var rand = new Random();
            int run = rand.Next(0, 11);
            bool killswitch = false;
            string randomLetter = "-";
            string userInput = "----";
            int score = 0;
            while (killswitch != true)
            {
                run = rand.Next(0, 11);
                if (run == 0)
                {
                    randomLetter = "o";
                    newTimer(killswitch, randomLetter);
                    Console.Clear();
                    userInput = Console.ReadLine();
                    if (userInput.ToLower() == randomLetter)
                    {
                        Console.WriteLine(" ");
                        score += 1;
                        Console.WriteLine("Congratulations! Your score is now " + score + "!");
                        for (int nextRound = 5; nextRound >= 0; nextRound--)
                        {
                            Console.Write("\rGenerating new round in {0} seconds.", nextRound);
                            System.Threading.Thread.Sleep(rand.Next(250, 1001));
                            Console.Clear();
                        }
                    }
                    else if (userInput.ToLower() != randomLetter)
                    {
                        Console.Clear();
                        Console.WriteLine("Game over! Your score was " + score + ". Play again later.");
                        killswitch = true;
                    }
                }
                else if (run == 1)
                {
                        randomLetter = "l";
                        newTimer(killswitch, randomLetter);
                        Console.Clear();
                        userInput = Console.ReadLine();
                        if (userInput.ToLower() == randomLetter)
                        {
                            Console.WriteLine(" ");
                            score += 1;
                            Console.WriteLine("Congratulations! Your score is now " + score + "!");
                            for (int nextRound = 5; nextRound >= 0; nextRound--)
                            {
                                Console.Write("\rGenerating new round in {0} seconds.", nextRound);
                                System.Threading.Thread.Sleep(rand.Next(250, 1001));
                                Console.Clear();
                            }
                        }
                        else if (userInput.ToLower() != randomLetter)
                        {
                            Console.Clear();
                            Console.WriteLine("Game over! Your score was " + score + ". Play again later.");
                            killswitch = true;
                        }

                }
                else if (run == 2)
                {
                        randomLetter = "u";
                        newTimer(killswitch, randomLetter);
                        Console.Clear();
                        userInput = Console.ReadLine();
                        if (userInput.ToLower() == randomLetter)
                        {
                            Console.WriteLine(" ");
                            score += 1;
                            Console.WriteLine("Congratulations! Your score is now " + score + "!");
                            score += 1;
                            for (int nextRound = 5; nextRound >= 0; nextRound--)
                            {
                                Console.Write("\rGenerating new round in {0} seconds.", nextRound);
                                System.Threading.Thread.Sleep(rand.Next(250, 1001));
                                Console.Clear();
                            }
                        }
                        else if (userInput.ToLower() != randomLetter)
                        {
                            Console.Clear();
                            Console.WriteLine("Game over! Your score was " + score + ". Play again later.");
                            killswitch = true;
                        }
                }
                else if (run == 3)
                {
                        randomLetter = "f";
                        newTimer(killswitch, randomLetter);
                        Console.Clear();
                        userInput = Console.ReadLine();
                        if (userInput.ToLower() == randomLetter)
                        {
                            Console.WriteLine(" ");
                            score += 1;
                            Console.WriteLine("Congratulations! Your score is now " + score + "!");
                            for (int nextRound = 5; nextRound >= 0; nextRound--)
                            {
                                Console.Write("\rGenerating new round in {0} seconds.", nextRound);
                                System.Threading.Thread.Sleep(rand.Next(250, 1001));
                                Console.Clear();
                            }
                        }
                        else if (userInput.ToLower() != randomLetter)
                        {
                            Console.Clear();
                            Console.WriteLine("Game over! Your score was " + score + ". Play again later.");
                            killswitch = true;
                        }
                }
                else if (run == 4)
                {
                        randomLetter = "a";
                        newTimer(killswitch, randomLetter);
                        Console.Clear();
                        userInput = Console.ReadLine();
                        if (userInput.ToLower() == randomLetter)
                        {
                            Console.WriteLine(" ");
                            score += 1;
                            Console.WriteLine("Congratulations! Your score is now " + score + "!");
                            for (int nextRound = 5; nextRound >= 0; nextRound--)
                            {
                                Console.Write("\rGenerating new round in {0} seconds.", nextRound);
                                System.Threading.Thread.Sleep(rand.Next(250, 1001));
                                Console.Clear();
                            }
                        }
                        else if (userInput.ToLower() != randomLetter)
                        {
                            Console.Clear();
                            Console.WriteLine("Game over! Your score was " + score + ". Play again later.");
                            killswitch = true;
                        }
                }
                else if (run == 5)
                {
                        randomLetter = "j";
                        newTimer(killswitch, randomLetter);
                        Console.Clear();
                        userInput = Console.ReadLine();
                        if (userInput.ToLower() == randomLetter)
                        {
                            Console.WriteLine(" ");
                            score += 1;
                            Console.WriteLine("Congratulations! Your score is now " + score + "!");
                            for (int nextRound = 5; nextRound >= 0; nextRound--)
                            {
                                Console.Write("\rGenerating new round in {0} seconds.", nextRound);
                                System.Threading.Thread.Sleep(rand.Next(250, 1001));
                                Console.Clear();
                            }
                        }
                        else if (userInput.ToLower() != randomLetter)
                        {
                            Console.Clear();
                            Console.WriteLine("Game over! Your score was " + score + ". Play again later.");
                            killswitch = true;
                        }
                }
                else if (run == 6)
                {
                        randomLetter = "i";
                        newTimer(killswitch, randomLetter);
                        Console.Clear();
                        userInput = Console.ReadLine();
                        if (userInput.ToLower() == randomLetter)
                        {
                            Console.WriteLine(" ");
                            score += 1;
                            Console.WriteLine("Congratulations! Your score is now " + score + "!");
                            for (int nextRound = 5; nextRound >= 0; nextRound--)
                            {
                                Console.Write("\rGenerating new round in {0} seconds.", nextRound);
                                System.Threading.Thread.Sleep(rand.Next(250, 1001));
                                Console.Clear();
                            }
                        }
                        else if (userInput.ToLower() != randomLetter)
                        {
                            Console.Clear();
                            Console.WriteLine("Game over! Your score was " + score + ". Play again later.");
                            killswitch = true;
                        }
                }
                else if (run == 7)
                {
                        randomLetter = "m";
                        newTimer(killswitch, randomLetter);
                        Console.Clear();
                        userInput = Console.ReadLine();
                        if (userInput.ToLower() == randomLetter)
                        {
                            Console.WriteLine(" ");
                            score += 1;
                            Console.WriteLine("Congratulations! Your score is now " + score + "!");
                            for (int nextRound = 5; nextRound >= 0; nextRound--)
                            {
                                Console.Write("\rGenerating new round in {0} seconds.", nextRound);
                                System.Threading.Thread.Sleep(rand.Next(250, 1001));
                                Console.Clear();
                            }
                        }
                        else if (userInput.ToLower() != randomLetter)
                        {
                            Console.Clear();
                            Console.WriteLine("Game over! Your score was " + score + ". Play again later.");
                            killswitch = true;
                        }
                }
                else if (run == 8)
                {
                        randomLetter = "s";
                        newTimer(killswitch, randomLetter);
                        Console.Clear();
                        userInput = Console.ReadLine();
                        if (userInput.ToLower() == randomLetter)
                        {
                            Console.WriteLine(" ");
                            score += 1;
                            Console.WriteLine("Congratulations! Your score is now " + score + "!");
                            score += 1;
                            for (int nextRound = 5; nextRound >= 0; nextRound--)
                            {
                                Console.Write("\rGenerating new round in {0} seconds.", nextRound);
                                System.Threading.Thread.Sleep(rand.Next(250, 1001));
                                Console.Clear();
                            }
                        }
                        else if (userInput.ToLower() != randomLetter)
                        {
                            Console.Clear();
                            Console.WriteLine("Game over! Your score was " + score + ". Play again later.");
                            killswitch = true;
                        }
                }
                else if (run == 9)
                {
                        randomLetter = "e";
                        newTimer(killswitch, randomLetter);
                        Console.Clear();
                        userInput = Console.ReadLine();
                        if (userInput.ToLower() == randomLetter)
                        {
                            Console.WriteLine(" ");
                            score += 1;
                            Console.WriteLine("Congratulations! Your score is now " + score + "!");
                            score += 1;
                            for (int nextRound = 5; nextRound >= 0; nextRound--)
                            {
                                Console.Write("\rGenerating new round in {0} seconds.", nextRound);
                                System.Threading.Thread.Sleep(rand.Next(250, 1001));
                                Console.Clear();
                            }
                        }
                        else if (userInput.ToLower() != randomLetter)
                        {
                            Console.Clear();
                            Console.WriteLine("Game over! Your score was " + score + ". Play again later.");
                            killswitch = true;
                        }
                }
                else if (run == 10)
                {
                        randomLetter = "k";
                        newTimer(killswitch, randomLetter);
                        Console.Clear();
                        userInput = Console.ReadLine();
                        if (userInput.ToLower() == randomLetter)
                        {
                            Console.WriteLine(" ");
                            score += 1;
                            Console.WriteLine("Congratulations! Your score is now " + score + "!");
                            score += 1;
                            for (int nextRound = 5; nextRound >= 0; nextRound--)
                            {
                                Console.Write("\rGenerating new round in {0} seconds.", nextRound);
                                System.Threading.Thread.Sleep(rand.Next(250, 1001));
                                Console.Clear();
                            }
                        }
                        else if (userInput.ToLower() != randomLetter)
                        {
                            Console.Clear();
                            Console.WriteLine("Game over! Your score was " + score + ". Play again later.");
                            killswitch = true;
                        }
                }
            }
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to they Keyboard Test! To get started, please press any key to begin!");
            Console.ReadKey();
            Game();
        }
    }
}

