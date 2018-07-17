using System;
namespace Learning
{
    public class Subtraction : Operation
    {
        public Subtraction(float _x, float _y) : base(_x, _y) {}

        protected override float Calculate()
        {
            return (x - y);
        }
    }
}
