using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    internal class Heir2 : B
    {
        public override void MyName(string name)
        {
            base.MyName(name);
        }
        public override int Sum(int a, int b)
        {
            return base.Sum(a, b);
        }
        public override double Math(int a, int b)
        {
            return a * b;
        }
    }
}
