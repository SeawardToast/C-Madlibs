using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madlibs
{
    class Program
    {
        public String myString;
        public String yourString;
        public String aString;
        public String answer;

        static void Main(string[] args)
        {

            Console.WriteLine("Hello, what's your name?");
            string myString = Console.ReadLine();
            Console.WriteLine("Hello {0}! That's a cool name, what's your favorite color?", myString);
            string yourString =  Console.ReadLine();
            Console.WriteLine("Your name is {0} and your favorite color is {1}!  (press enter to continue)", myString, yourString);
            Console.ReadLine();
            Console.WriteLine("What city do you live in?");
            string aString = Console.ReadLine();
            Console.WriteLine("{0}! That is a great place to live!  (press enter to continue)", aString);
            Console.ReadLine();
            Console.WriteLine("So let me see.. Your name is {0}, your favorite color is {1}, and you live in {2}. Do you think I'm smart? yes/no", myString, yourString, aString);
            string answer = Console.ReadLine();
            if (answer == "yes")
            {
                Console.WriteLine("So do I... Hey! Do you want to play a game? yes/no");
            }
            else
            {
                Console.WriteLine("Well I think I am! Let me prove it.. Want to play a game? yes/no");
            }
            Console.ReadLine();
             


        }
    }
}
