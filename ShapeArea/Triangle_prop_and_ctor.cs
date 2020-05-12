using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculation
{
    partial class Triangle:Shape
    {
        public override string ShapeName { get; set; }
        public double Side_A { get; set; }
        public double Side_B { get; set; }
        public double Side_C { get; set; }
        public override bool ShapeCheck
        {
            get { return Side_A + Side_B > Side_C && Side_A + Side_C > Side_B && Side_C + Side_B > Side_A; }
        }
        public override double ShapeArea
        {
            get
            {
                if (ShapeCheck)
                {
                    double halfPerimeter = (Side_A + Side_B + Side_C)/2;
                    double TriangleArea = Math.Sqrt(halfPerimeter * (halfPerimeter - Side_A) * (halfPerimeter - Side_B) * (halfPerimeter - Side_C));
                    return Math.Round(TriangleArea, 4);
                }
                else 
                {
                    throw new ArgumentOutOfRangeException("Warning! The sum of any 2 sides of a triangle must be greater than the measure of the third side.\nPlease check input parameters");
                } 
            }
        }


        public bool IsRightTriangle
        {
            get { return Side_A*Side_A + Side_B*Side_B == Side_C*Side_C ||
                         Side_A*Side_A + Side_C*Side_C == Side_B*Side_B ||
                         Side_C*Side_C + Side_B*Side_B == Side_A*Side_A; }
        }
        public Triangle(string ShapeName, double a, double b, double c)
        {

                Side_A = a;
                Side_B = b;
                Side_C = c;
                this.ShapeName = ShapeName;

        }
        public Triangle(double a, double b, double c)
        {
                Side_A = a;
                Side_B = b;
                Side_C = c;
                ShapeName = "NoName";
        }

    }
}
