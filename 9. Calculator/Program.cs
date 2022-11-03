using System;
using System.Collections.Generic;

namespace _9.Calculator
{
    public class Program
    {
        public double Add(double f_number,double s_number)
        {
            return f_number + s_number;
        }
        public double Subtract(double f_number, double s_number)
        {
            return f_number - s_number;
        }
        public double Multiply(double f_number, double s_number)
        {
            return f_number * s_number;
        }
        public double Divide(double f_number, double s_number)
        {
            return f_number / s_number;
        }

        public void Calculator()
        {
            bool end = false;
            Console.WriteLine("What's the first number?");
            double f_number = Convert.ToDouble(Console.ReadLine());

            while (!end)
            {
                double result = 0;
                Console.WriteLine("Pick an operation ( +, -, *, /");
                char oper = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("What's the second number?");
                double s_number = Convert.ToDouble(Console.ReadLine());

                switch (oper)
                {
                    case '+':
                        result = Add(f_number, s_number);
                        break;
                    case '-':
                        result = Subtract(f_number, s_number);
                        break;
                    case '*':
                        result = Multiply(f_number, s_number);
                        break;
                    case '/':
                        result = Divide(f_number, s_number);
                        break;
                }

                Console.WriteLine($"{f_number} {oper} {s_number} = {result}");

                Console.WriteLine(Environment.NewLine + "Type 'y' to continue calculating with {result}, or type 'n' to start a new calculation");
                char cont = Convert.ToChar(Console.ReadLine());
                if (cont == 'n')
                {
                    end = true;
                    Calculator();
                }
                else
                {
                    f_number = result;
                }
            }
        }
        static void Main()
        {
            Program function = new Program();
            function.Calculator();
        }
    }
}