using System;

namespace Casting_Morgan_Daniel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your favorite whole Number"); //Ask the user for their fav whole number
            int myWholNum = Convert.ToInt32(Console.ReadLine()); //Makes and integer and assigns it to the variable 'myWholNum' and converts the string to an Int

            Console.WriteLine("Your Chosen Whole Number is " + myWholNum); //Tells the user their favorite whole number

            Console.WriteLine("Are you 50 years old? (Enter 'true' or 'false')"); //Then asks if the user is 50 years old or not, then asks to enter 'true' or 'false' as an answer

            bool isTrue = Convert.ToBoolean(Console.ReadLine()); // assigs the variable 'isTrue' to bool, then converts it to boolean

            Console.WriteLine($"It is {isTrue} that you're 50 years old!"); //then prints out saying that it's true or false that they're 50 years old
        }
    }
}
