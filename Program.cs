using System;
using System.Collections.Generic;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me an expression to evaluate:");

            string expression = Console.ReadLine().Trim();

            var expressionArr = expression.Split(" ");

            var numList = new List<int>();

            var operatorList = new List<string>();

            var calculatorOperators = new List<string>() { "+", "-", "*", "/" };

            for (int i = 0; i < expressionArr.Length; i++)
            {
                int num;
                string opperator;
                if(Int32.TryParse(expressionArr[i], out int j))
                {
                    numList.Add(j);
                } else if ( calculatorOperators.Contains( expressionArr[i] ))
                {
                    operatorList.Add(expressionArr[i]);
                }

            }
            Console.WriteLine(OperatorEvaluator.Evaluator(operatorList[0], numList[0], numList[1]));
        }
    }
}
