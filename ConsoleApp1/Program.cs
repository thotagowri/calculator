using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            char again = 'y';
            while (again == 'y')
            {
                //string num1;
                //double number1;
                string num2;
                double number2 = 0;
                double total;
                char oper = '+';
                string num1;
                double number1 = 0;

                while (true)
                {
                    Console.WriteLine("Enter your first number: ");

                    num1 = Console.ReadLine();


                    if (double.TryParse(num1, out number1))
                    {
                        break;
                    }


                    else
                    {
                        Console.WriteLine("The value entered is not a int");
                    }

                }

                Console.WriteLine("Please choose one of the operator: Addition +, Substraction -, Multiplication *, Division /, Percentage % ");
                Console.WriteLine("Enter your opperator");


                oper = char.Parse(Console.ReadLine());

                while (true)
                {
                    Console.WriteLine("Enter your second number: ");

                    num2 = Console.ReadLine();


                    if (double.TryParse(num2, out number2))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The value entered is not a int");
                    }

                }

                if (oper == '+')
                {
                    total = number1 + number2;
                    Console.WriteLine("Your Answer is " + total);
                }

                else if (oper == '-')
                {
                    total = number1 - number2;
                    Console.WriteLine("Your Answer is " + total);
                }

                else if (oper == '*')
                {
                    total = number1 * number2;
                    Console.WriteLine("Your Answer is " + total);
                }

                else if (oper == '/')
                {
                    total = number1 - number2;
                    Console.WriteLine("Your Answer is " + total);
                }

                else if (oper == '%')
                {
                    total = number1 % number2;
                    Console.WriteLine("Your Answer is " + total);
                }

                else
                {
                    Console.WriteLine("Invalid Operator");

                }

                Console.WriteLine("Do you want to make another caliculation? (y/n)");
                again = char.Parse(Console.ReadLine());

            }

        }

    }
}



