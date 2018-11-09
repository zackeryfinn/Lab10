using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            WindowPop newConsole = new WindowPop();
            newConsole.WindowOpen();

            var loopCounter = 0;
            bool repeatMain = true;
            while (repeatMain)
            { 
            Validation intro = new Validation();
            intro.Hello();
            double radius = intro.GetRadius();
            double radiusInput = radius;

            Circle circleInfo = new Circle(radiusInput);
            double circumference = circleInfo.circumference(radiusInput);
            double area = circleInfo.area(radiusInput);
            circleInfo.CalculateFormattedCircumference(circumference);
            circleInfo.CalculateFormattedArea(area);

            loopCounter++;
            repeatMain = ExitProgram();
            }
            string obby;
            if (loopCounter == 1) { obby = "object"; }
            else { obby = "objects"; }

            Console.WriteLine($"You created {loopCounter} circle {obby}.");
            Console.WriteLine("Good bye!");
            Console.ReadKey();
        }
        public static bool ExitProgram()
        {
            bool repeatMain = true;
            Console.WriteLine();
            Console.WriteLine("Would you like to create another circle?");
            Console.Write("Please type \"y\" to continue or any other key to exit: ");
            string repeatInputB = Console.ReadLine();
            Console.WriteLine();
            if (!repeatInputB.Equals("y", StringComparison.OrdinalIgnoreCase))
            {
                repeatMain = false;
            }
            return repeatMain;
        }
    }
}
    

