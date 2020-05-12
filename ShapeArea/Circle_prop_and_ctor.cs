using System;

namespace ShapeAreaCalculation
{
    partial class Circle:Shape
    {
        public override string ShapeName { get; set; }
        public double CircleRadius { get; set; }
        public override bool ShapeCheck
        {
            get
            {
                if (CircleRadius > 0)
                {
                    return true;
                }
                else
                {
                    throw new Exception("Warning! Radius must be positive!\nPlease check input parameters");
                }
            }
        }
        public override double ShapeArea
        {
            get
            {
                if (ShapeCheck)
                {
                    double circleArea = Math.PI * Math.Pow(CircleRadius, 2);
                    return Math.Round(circleArea, 4);
                }
                else
                {
                    throw new Exception("Warning! Radius must be positive!\nPlease check input parameters");
                }
            }   
        } 
        public Circle(string ShapeName, double CircleRadius)
        {
            this.CircleRadius = CircleRadius;
            this.ShapeName = ShapeName;
        }
        public Circle(double CircleRadius)
        {
            this.CircleRadius = CircleRadius;
            ShapeName = "NoName";

        }


    }
}
