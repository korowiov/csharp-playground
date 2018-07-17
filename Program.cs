using System;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator(12, 12, "*");
            calc.Result();
        }
    }
}
