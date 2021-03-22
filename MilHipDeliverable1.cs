using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome to the MilHip Conversion Program! "); 

            bool runAgain = true;

            while (runAgain == true)
            {

            
            string a = "fidget spinners";
            string b = "inch";
            string c = "memes";
            string d = "foot";
            double g = 3.5;
            int e = 5;

                {

                    Console.Write("Please enter an amount: ");
                    string input = Console.ReadLine();
                    double num1 = double.Parse(input);

                    Console.Write("Please enter a measurement type: (inch, fidget spinners, memes, or foot) ");
                    string type1 = Console.ReadLine();

                    if (type1 == a)
                    {
                        Console.WriteLine("Your result is " + num1 / g + " inches ");
                    }
                    else if (type1 == b)
                    {
                        Console.WriteLine("Your result is " + num1 * g + " fidget spinners ");
                    }
                    else if (type1 == c)
                    {
                        Console.WriteLine("Your result is " + num1 / e + " foot ");
                    }
                    else if (type1 == d)
                    {
                        Console.WriteLine("Your result is " + num1 * e + " memes ");
                    }
                    else 
                    {
                        Console.WriteLine("There is no available answer. ");
                    }
                    Console.WriteLine("Would you like to ran another conversion? y/n ");
                    string input2 = Console.ReadLine();

                        if (input2 == "n")
                        {
                        break;

                        }
                        else if (input2 == "y")
                        {
                            Console.WriteLine("Great, restarting application ");
                    }
                            else
                    {
                        break;
                    }
                }
                    
            } 
        } 
    }
}
