using System;
namespace Learning
{
    public class Sum : Operation
    {
        public Sum(float _x, float _y) : base(_x, _y) {}

        protected override float Calculate()
        {
            return (x + y);
        }
    }
}
