using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madlibs
{
    class Program
    {
        public static string playerName;
        public static string favoriteColor;
        public static string city;
        public static string smartAnswer;
        public static string gameAnswer;
        public static string libAnswer;
        public static string name;
        public static string name2;
        public static string location;
        public static string location2;
        public static string bandName;
        public static string leadSinger;
        public static string food;
        public static string food2;
        public static string resturant;
        public static string resturant2;
        public static string verb;
        public static string aisleNumber;
        public static string car1;
        public static string libChoice;

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
                        Console.ReadLine();
                        MadlibQuestions();
                    }
                    else if (libAnswer == "no")
                    {
                        Console.WriteLine("Okay, so here's some instructions. I will ask you to enter a series of nouns, adajectives, and verbs. You can be as creative as you would like! Once I have asked you all the questions, you can choose to have either mad lib number one, two, or three. I will then write you a short story involving all of your answers to my questions!  (press enter)");
                        Console.ReadLine();
                        MadlibQuestions();
                    }
                    else
                    {
                        Confused();
                    }
                }
                else if (gameAnswer == "no")
                {
                    Console.WriteLine("Awe that sucks.. Come back when you want to play!");
                    Console.WriteLine("Game Over  (press enter)");
                    Console.ReadLine();
                    Environment.Exit(1);
                }
                else
                {
                    Confused();
                }
            }
            else if (smartAnswer == "no")
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
                    Confused();
                }


            }
            else
            {
                Confused();
            }
            



        }

        public static void MadlibQuestions()
        {
            Console.WriteLine("I am going to ask you to enter words, once you have entered them all you will be given a choice of which madlib you want using all of your answers! (press enter)");
            Console.ReadLine();
            Console.WriteLine("Enter a name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter another name");
            string name2 = Console.ReadLine();
            Console.WriteLine("Enter a location");
            string location = Console.ReadLine();
            Console.WriteLine("Enter another location");
            string location2 = Console.ReadLine();
            Console.WriteLine("Enter a band name (get creative)");
            string bandName = Console.ReadLine();
            Console.WriteLine("Enter the name of the band's lead singer...");
            string leadSinger = Console.ReadLine();
            Console.WriteLine("Enter a food item");
            string food = Console.ReadLine();
            Console.WriteLine("Enter another food item");
            string food2 = Console.ReadLine();
            Console.WriteLine("Enter a food store/resturant");
            string resturant = Console.ReadLine();
            Console.WriteLine("Enter another food store/resturant");
            string resturant2 = Console.ReadLine();
            Console.WriteLine(@"Enter a verb (ending in ""ing"")");
            string verb = Console.ReadLine();
            Console.WriteLine("Enter a number");
            string aisleNumber = Console.ReadLine();
            Console.WriteLine("Enter a car model");
            string car1 = Console.ReadLine();
            Console.WriteLine("Now that you have answered all the questions, which madlib do you want? (enter 1, 2 or 3)");
            string libChoice = Console.ReadLine();

            if (libChoice == "1")
            {
                Madlib1();
            }
            else if (libChoice == "2")
            {
                Madlib2();
            }
            else
            {
                Madlib3();
            }
        }

        static void Madlib1()
        {
            Console.WriteLine("This is madlib 1");
            Console.WriteLine();
            Console.WriteLine("One day, {0} went to the {2}. While he was at the {2} he met a new friend! The friends name was {1} and {0} loved him. They even liked the same band! They talked on and on about how awesome {4}'s albums were and how they were in love with the lead singer {3}. They began their new friendship and did everything together! One day they decided to go for a picnic. {0}'s favorite food was {5}, but {2}'s favorite food was {6}! They went to {7} for the {5} and easily found it, however they couldn't find any {6}! They searched the entire store but to no avail, they could not find any {6}! They gave up at {7} and started out on their way to {8}. Once they arrived they began {9} down the aisles looking for some {6}! They turned the corner into aisle {10}... Finally! Right there on the wall was some {6}.. After all that searching they had finally found some. They checked out and hopped in their {11}.. They sped off to the {12}, the place they had agreed to go eat lunch and lived happily ever after.", name, name2, location, leadSinger, bandName, food, food2, resturant, resturant2, verb, aisleNumber, car1, location2);
            Console.WriteLine("Press enter to choose new questions and choose a new madlib, or exit!");
            Console.ReadLine();
            MadlibQuestions();
        }

        static void Madlib2()
        {
            Console.WriteLine("This is madlib 2 it is in progress.");
            Console.ReadLine();
            MadlibQuestions();
        }

        static void Madlib3()
        {
            Console.WriteLine("This is madlib 3 it is in progress.");
            Console.ReadLine();
            MadlibQuestions();
        }

        static void Confused()
        {
            Console.WriteLine("I'm sorry I didn't quite understand what you said! Please restart (press enter)");
            Console.ReadLine();
            Intro();
        }

    }

      

    }


