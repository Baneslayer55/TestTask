
namespace ShapeAreaCalculation
{
    abstract class Shape
    {
        public abstract string ShapeName { get; set; }
        public abstract double ShapeArea { get; }
        public abstract bool ShapeCheck { get; }
    }
}
