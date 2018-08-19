using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carrying_from_if_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            //if statements picking up from "Learn how to delete file" TASK 4 Odd or Even
            Console.WriteLine("pick a number and I will tell you if it is odd or even");
            Int32 usersnumber = Int32.Parse(Console.ReadLine());
            //use modulus 
            if (usersnumber % 2 == 0)
                Console.WriteLine("the number you gave me was even");
            else
                Console.WriteLine("the number you gave me was odd");
            Console.WriteLine("did you understand modulus? me niether goodbye");
            Console.WriteLine("press enter to countinue");
            Console.ReadLine();

            //Pin Number exersize
            Console.WriteLine("enter a pin number");
            int Pin1 = int.Parse(Console.ReadLine());
            if (Pin1 > 1000 && Pin1 < 9999)
            {
                Console.WriteLine("please enter same number again");
                int Pin2 = int.Parse(Console.ReadLine());
                if (Pin2 == Pin1)
                    Console.WriteLine("Success I now have all your money");
                else
                    Console.WriteLine("the pin did not match the first pin Start again");
            }

            else
                Console.WriteLine("your Pin needs to between 1000 and 9999 Start again");



            //Parlindromes
            Console.WriteLine("if you want your money back ...");
            Console.WriteLine("please make a 3 letter word and I will tell you if it's a parlindrome");
            Console.WriteLine("type first letter and press enter");
            string firstLetter = Console.ReadLine();
            Console.WriteLine("enter 2nd number");
            string secondLetter = Console.ReadLine();
            Console.WriteLine("enter 3rd number");
            string thirdLetter = Console.ReadLine();

            if (firstLetter == thirdLetter)
            {
                if (secondLetter == "a" || secondLetter == "e" || secondLetter == "i" || secondLetter == "u" || secondLetter == "o" || secondLetter == "y" || secondLetter == "w")
                    Console.WriteLine("Congradulations you have your money back {0} {1} {2}", firstLetter, secondLetter, thirdLetter);
                else Console.WriteLine("you may have to Google, I don't know that word");

            }
            else Console.WriteLine("Not a parlindrome! You wrote: {0} {1} {2}", firstLetter, secondLetter, thirdLetter);

            Console.WriteLine("the end, thankyou for playing");

            Console.ReadLine();
            Console.Clear();


            
                    
           
           
            









        }
    }
}
