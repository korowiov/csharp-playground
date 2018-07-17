using System;
namespace Learning
{
    public class Calculator
    {
        private float x;
        private float y;
        private string op;

        public Calculator(float _x, float _y, string _op)
        {
            x = _x;
            y = _y;
            op = _op;
        }

        public void Result()
        {
            Console.WriteLine(CalculateClass().Result());
        }


        private Operation CalculateClass()
        {
            switch (op)
            {
                case "+":
                    return new Sum(x, y);
                case "-":
                    return new Subtraction(x, y);
                case "*":
                    return new Multiplication(x, y);
                default:
                    return new Division(x, y);
            }
        }
    }
}
