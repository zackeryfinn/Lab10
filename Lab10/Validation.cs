using System;

namespace Lab10
{
    public class Validation
    {
        //this section I will welcome the user and get the radius information
        public void Hello()
        {
            Console.WriteLine(" Welcome to the circle tester!");
            Console.Write(" Enter radius: ");

        }
        public double GetRadius()
        {
            var userInput = Console.ReadLine();
            double radiusInput = 0;
            while (!double.TryParse(userInput, out radiusInput) || radiusInput < 0 )
            {
                Console.WriteLine(" Sorry, that is not a valid input.");
                Console.Write(" Please enter a number: ");
                userInput = Console.ReadLine();
                Console.WriteLine();
            }
            return radiusInput;
        }
   
    }
}
