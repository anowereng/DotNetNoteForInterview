using System;
using System.Collections.Generic;
using System.Text;

namespace OCP_Example_Of_Square_WithoutRefactore
{
    public class Rectangle: Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public override int GetArea()
        {
            return Width * Height;
        }
    }
}
