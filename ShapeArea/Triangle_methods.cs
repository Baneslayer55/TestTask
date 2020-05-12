using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculation
{
    partial class Triangle:Shape
    {
        public override string ToString() 
        {
            if (IsRightTriangle)
            {
               return $"Your right triangle {ShapeName} has sides A={Side_A}, B={Side_B}, C={Side_C} and it's area is {ShapeArea}.";
            }
            else
            {
                return $"Your triangle {ShapeName} has sides A={Side_A}, B={Side_B}, C={Side_C} and it's area is {ShapeArea}.";
            }
        }
        public string DisplaySides() 
        {
            return "Your triangle {ShapeName} has sides A={Side_A}, B={Side_B}, C={Side_C}";

        }
      
    }
}
