using System;
namespace Learning
{
    public class Division : Operation
    {
        public Division(float _x, float _y) : base(_x, _y) { }

        protected override float Calculate()
        {
            return (x / y);
        }
    }
}
