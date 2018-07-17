using System;
namespace Learning
{
    abstract public class Operation
    {
        protected float x;
        protected float y;

        public Operation(float _x, float _y)
        {
            x = _x;
            y = _y;
        }

        public float Result()
        {
            return Calculate();
        }

        abstract protected float Calculate();
    }
}