using System;
using System.Collections.Generic;
using System.Text;

namespace OCP_Example_Of_Square_WithoutRefactore
{
    public class AreaCalculator
    {
        public int GetArea(Rectangle [] shapes)
        {
            var area = 0;
            foreach (var shape in shapes)
            {
                area+= shape.Width * shape.Height;
            }
            return area;
        }
        public int GetArea(Triangle[] shapes)
        {
            var area = 0;
            foreach (var shape in shapes)
            {
                area += shape.Width * shape.Height;
            }
            return area;
        }
    }
}
