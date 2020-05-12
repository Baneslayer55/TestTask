using System;


namespace ShapeAreaCalculation
{
    partial class Circle:Shape
    {
        public override string ToString()
        {
            if (ShapeCheck)
            {
                return $"Your circle {ShapeName} with a radius of {CircleRadius} has an area of {ShapeArea}.";
            }
            else
            {
                throw new Exception("Warning! Radius must be positive!\nPlease check input parameters"); ;
            }
        }
    }
}
