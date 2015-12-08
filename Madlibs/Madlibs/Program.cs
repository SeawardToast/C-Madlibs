using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madlibs
{
    class Program
    {
        public string playerName;
        public string favoriteColor;
        public string city;
        public string smartAnswer;
        public string gameAnswer;
        public string libAnswer;

        static void Main(string[] args)
        {
            Intro();
        }

        static void Intro()
        {
            Console.WriteLine("Hello, what's your name?");
            string playerName = Console.ReadLine();
            Console.WriteLine("Hello {0}! That's a cool name, what's your favorite color?", playerName);
            string favoriteColor = Console.ReadLine();
            Console.WriteLine("Your name is {0} and your favorite color is {1}!  (press enter to continue)", playerName, favoriteColor);
            Console.ReadLine();
            Console.WriteLine("What city do you live in?");
            string city = Console.ReadLine();
            Console.WriteLine("{0}! That is a great place to live!  (press enter to continue)", city);
            Console.ReadLine();
            Console.WriteLine("So let me see.. Your name is {0}, your favorite color is {1}, and you live in {2}. Do you think I'm smart? yes/no", playerName, favoriteColor, city);
            string smartAnswer = Console.ReadLine();
            if (smartAnswer == "yes")
            {
                Console.WriteLine("So do I... Hey! Do you want to play a game? yes/no");
                string gameAnswer = Console.ReadLine();

                if (gameAnswer == "yes")
                {
                    Console.WriteLine("Awesome! Have you ever done a mad lib before? yes/no");
                    string libAnswer = Console.ReadLine();

                    if (libAnswer == "yes")
                    {
                        Console.WriteLine("Okay, let's begin.  (press enter)");
                        Madlib();
                    }
                    else if (libAnswer == "no")
                    {
                        Console.WriteLine("Okay, so here's some instructions. I will ask you to enter a series of nouns, adajectives, and verbs. You can be as creative as you would like! Once I have asked you all the questions, you can choose to have either mad lib number one, two, or three. I will then write you a short story involving all of your answers to my questions!  (press enter)");
                        Console.ReadLine();
                        Madlib();
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry I didn't quite understand what you said! Please restart (press enter)");
                        Console.ReadLine();
                        Intro();
                    }
                }
                else
                {
                    Console.WriteLine("Awe that sucks.. Come back when you want to play!");
                    Console.WriteLine("Game Over  (press enter)");
                    Console.ReadLine();
                    Environment.Exit(1);
                }
            }
            else
            {
                Console.WriteLine("Well I think I am! Let me prove it.. Want to play a game? yes/no");
                string gameAnswer = Console.ReadLine();

                if (gameAnswer == "yes")
                {
                    Console.WriteLine("Awesome! Have you ever done a mad lib before? yes/no");
                    Console.ReadLine();

                }
                else if (gameAnswer == "no")
                {
                    Console.WriteLine("Awe that sucks.. Come back when you want to play!");
                    Console.WriteLine("Game Over  (press enter)");
                }
                else
                {
                    Console.WriteLine("I'm sorry I didn't quite understand what you said! Please restart (press enter)");
                    Console.ReadLine();
                    Intro();
                }


            }
            //start madlib
            Madlib();



        }
    }

        static void Madlib()
        {
            Console.WriteLine("We're in baby");
            Console.ReadLine();
        }

    }


