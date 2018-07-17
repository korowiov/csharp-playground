using System;
namespace Learning
{
    public class Multiplication : Operation
    {
        public Multiplication(float _x, float _y) : base(_x, _y) {}

        protected override float Calculate()
        {
            return (x * y);
        }
    }
}
