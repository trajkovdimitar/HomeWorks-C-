using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.work._2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            /*
            Console.WriteLine("SumOfEven");
            int[] array = new int[6];
            Console.WriteLine("Enter integer no.1:");
            int number1;
            string value1 = Console.ReadLine();
            Console.WriteLine("Enter integer no.2:");
            int number2;
            string value2 = Console.ReadLine();
            Console.WriteLine("Enter integer no.3:");
            int number3;
            string value3 = Console.ReadLine();
            Console.WriteLine("Enter integer no.4:");
            int number4;
            string value4 = Console.ReadLine();
            Console.WriteLine("Enter integer no.5:");
            int number5;
            string value5 = Console.ReadLine();
            Console.WriteLine("Enter integer no.5:");
            int number6;
            string value6 = Console.ReadLine();

            bool success1 = Int32.TryParse(value1, out number1);
            bool success2 = Int32.TryParse(value2, out number2);
            bool success3 = Int32.TryParse(value3, out number3);
            bool success4 = Int32.TryParse(value4, out number4);
            bool success5 = Int32.TryParse(value5, out number5);
            bool success6 = Int32.TryParse(value6, out number6);

            int result=0;

            if (success1&&success2&&success3&&success4&&success5&&success6)
            {
                if (number1 % 2 == 0)
                {
                     result += number1;
                }
                if (number2%2==0)
                {
                    result += 2;
                }
                if (number3%2==0)
                {
                    result += number3;
                }
                if (number4%2==0)
                {
                    result += number4;
                }
                if (number5%2==0)
                {
                    result += number5;
                }
                if (number6%2==0)
                {
                    result += number6;
                }

                Console.Clear();
                Console.WriteLine($"The result is: {result}");
            }
            else
            {
                Console.WriteLine("You entered wrong input!");
            }

            Console.ReadLine();
            */
            #endregion
            #region Task 2
            Console.WriteLine("StudentGroup");
            string[] studentsG1 = new string[] { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
            string[] studentsG2 = new string[] { "Marte", "Stefan", "Bojan", "Dime", "Srbo" };
            Console.WriteLine("Enter student group: ( there are 1 and 2 )");
            int number;
            string value = Console.ReadLine();
            bool success = Int32.TryParse(value, out number);
            if (success)
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine("The Students in G1 are:");
                        foreach (var item in studentsG1)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case 2:
                        Console.WriteLine("The Students in G2 are:");
                        foreach (var item in studentsG2)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    default:
                        Console.WriteLine("You have entered wrong number!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("You did not entered a number!");
            }
            Console.ReadLine();
            #endregion
        }
    }
}
