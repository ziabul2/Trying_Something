using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            // do Not remove this..

            // Data type...
            // int a = 20;
            // float b = 12.2F;
            // double c = 12.2;
            // bool isGread = true;
            // char latter = 'a';
            // string d = "This is a string";


            // Console.WriteLine("Write Something.....");
            // string inp = Console.ReadLine();

            // Console.WriteLine(inp);
            // Console.WriteLine(b);
            // Console.WriteLine(c);
            // Console.WriteLine(isGread);
            // Console.WriteLine(latter);
            // Console.WriteLine(d);
            // Console.WriteLine("Hello World! " + a);
            // Console.ReadLine();

            int firstOperand = 15;
            int secondOperand = 3;

            // Operators: Addition +, Subtraction -,Multiplication *, Division /

            int addResult = firstOperand + secondOperand;
            int subtractResult = firstOperand - secondOperand;
            int multiplyResult = firstOperand * secondOperand;
            int divisionResult = firstOperand / secondOperand;

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Arithmetic Operations with integer values");
            Console.WriteLine("--------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Adding " + firstOperand + " and " + secondOperand + "...... result is " + addResult);
            Console.WriteLine("Subtracting " + secondOperand + " from " + firstOperand + "...... result is " + subtractResult);
            Console.WriteLine("Multiplying " + firstOperand + " and " + secondOperand + "...... result is " + multiplyResult);
            Console.WriteLine("Dividing " + firstOperand + " by " + secondOperand + "...... result is " + divisionResult);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("--------------------");
            Console.WriteLine("Arithmetic Operations with decimal values");
            Console.WriteLine("--------------------");
            decimal firstOperandD = 15.0m;
            decimal secondOperatorD = 3.0m;

            decimal addResultD = firstOperandD + secondOperatorD;
            decimal subtractResultD = firstOperandD - secondOperatorD;
            decimal multiplyResultD = firstOperandD * secondOperatorD;
            decimal divisionResultD = firstOperandD / secondOperatorD;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Adding " + firstOperandD + " and " + secondOperatorD + "...... result is " + addResultD);
            Console.WriteLine("Subtracting " + secondOperatorD + " from " + firstOperandD + "...... result is " + subtractResultD);
            Console.WriteLine("Multiplying " + firstOperandD + " and " + secondOperatorD + "...... result is " + multiplyResultD);
            Console.WriteLine("Dividing " + firstOperandD + " from " + secondOperatorD + "...... result is " + divisionResultD);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("--------------------");

            int i = 10;
            Console.WriteLine("Integer i has value: " + i);
            i++;
            Console.WriteLine("Integer i has value(after increment): " + i);
            i--;
            Console.WriteLine("Integer i has value(after decrement): " + i);


            // Operator(remainder) - %

            int firstNum = 7;
            int seconNum = 3;

            Console.WriteLine("Remainder is : " + (firstNum % seconNum));




        }
    }
}
