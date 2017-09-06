using System;

namespace AbstractClasses
{
    partial class Program
    {
        public class Circle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Draw a circle.");
            }
        }
    }
}
