using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.work._1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            /*
            Console.WriteLine("RealCalculator");
            Console.WriteLine("Enter the First number:");
            int number1;
            string value1 = Console.ReadLine();
            int number2;
            Console.WriteLine("Enter the Second number:");
            string value2 = Console.ReadLine();
            
            bool success1 = Int32.TryParse(value1, out number1);
            bool success2 = Int32.TryParse(value2, out number2);

            if (success1&&success2)
            {
                Console.WriteLine("Enter the Operation");
                string operation = Console.ReadLine();
                if (operation == "+")
                {
                    Console.WriteLine(number1+number2);
                }
                if (operation=="-")
                {
                    Console.WriteLine(number1-number2);
                }
                if (operation=="*")
                {
                    Console.WriteLine(number1*number2);
                }
                if (operation=="/")
                {
                    Console.WriteLine(number1/number2);
                }
            }
            else
            {
                Console.WriteLine("You entered wrong input!");
            }
            Console.ReadLine();
            */
            #endregion
            #region Task 2
            /*
            Console.WriteLine("AverageNumber");
            Console.WriteLine("Enter the First number:");
            int number1;
            string value1 = Console.ReadLine();
            Console.WriteLine("Enter the Second number:");
            int number2;
            string value2 = Console.ReadLine();
            Console.WriteLine("Enter the third number:");
            int number3;
            string value3 = Console.ReadLine();
            Console.WriteLine("Enter the fourth number:");
            int number4;
            string value4 = Console.ReadLine();

            bool success1 = Int32.TryParse(value1, out number1);
            bool success2 = Int32.TryParse(value2, out number2);
            bool success3 = Int32.TryParse(value3, out number3);
            bool success4 = Int32.TryParse(value4, out number4);

            if (success1&&success2&&success3&&success4)
            {
                int sum = number1 + number2 + number3 + number4;
                Console.WriteLine($"The average of {number1}, {number2}, {number3} and {number4} is: "+sum/4);
            }
            else
            {
                Console.WriteLine("You have entered a wrong input!");
            }
            Console.ReadLine(); */
            #endregion
            #region Task 3
            Console.WriteLine("SwapNumbers");
            Console.WriteLine("Input the First Number:");
            int number1;
            string value1=Console.ReadLine();
            Console.WriteLine("Input the Second Number:");
            int number2;
            string value2 = Console.ReadLine();

            bool success1 = Int32.TryParse(value1, out number1);
            bool success2 = Int32.TryParse(value2, out number2);

            if (success1&&success2)
            {
                Console.Clear();
                Console.WriteLine("After Swapping:");
                Console.WriteLine($"First Number: {number2}");
                Console.WriteLine($"Second Number:: {number1}");
                Console.WriteLine("---------------------------");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("You have entered a wrong input!");
            }
            Console.ReadLine();
            #endregion
        }
    }
}
