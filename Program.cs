using System;

namespace fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname,lname;
            Console.Write("Please enter your first name : ");
            fname = Console.ReadLine();
            Console.Write("Please enter your last name : ");
            lname = Console.ReadLine();
            Console.Write($"Your full name is {fname} {lname}");
        }
    }
}
