using System;
namespace calculator
{
    public class OperatorEvaluator
    {
        public OperatorEvaluator ()
        {

        }

        public static int Evaluator(string givenOperator, int operandOne, int operandTwo)
        {
            int expressionValue;
            switch (givenOperator)
            {
                case "+":
                    expressionValue = operandOne + operandTwo;
                    break;
                case "-":
                    expressionValue = operandOne - operandTwo;
                    break;
                case "*":
                    expressionValue = operandOne * operandTwo;
                    break;
                case "/":
                    expressionValue = operandOne / operandTwo;
                    break;
                default:
                    throw new Exception("Not a valid operator.");
            }
            return expressionValue;
        }
    }
}
