using System;

namespace C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 1st operand    ");
            int Operand1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter 2nd operand    ");
            int Operand2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter Operator   ");
            char TheOperator = Convert.ToChar(Console.ReadLine());

            Calc(Operand1, Operand2, TheOperator);
        }

        static void Calc(int Operand1, int Operand2, char TheOperator){
            if(TheOperator == '+')
                Console.WriteLine("\nOperand1 + Operand2 = " + (Operand1 + Operand2));
            else if (TheOperator == '-')
                Console.WriteLine("\nOperand1 - Operand2 = " + (Operand1 - Operand2));
            else if (TheOperator == '/')
                Console.WriteLine("\nOperand1 / Operand2 = " + (Operand1 / Operand2));
            else if (TheOperator == '*')
                Console.WriteLine("\nOperand1 * Operand2 = " + (Operand1 * Operand2));
            else
                Console.WriteLine("\nInvalid Choice");
        }
    }
}
