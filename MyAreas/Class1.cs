using System;

namespace MyAreas
{
    public class Areas
    {
        public float Circle(int radius)
        {
            return (float)Math.PI * radius * radius;
        }
        public float Triangle(int b, int h)
        {
            return (float).5 * b * h;
        }
        public int Rectangle(int l, int b)
        {
            return l * b;
        }
    }
}
