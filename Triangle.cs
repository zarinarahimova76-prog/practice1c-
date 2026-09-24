
class Triangle : Shape
{
    private double baseLength;
    private double height;

    public Triangle(double baseLength, double height)
    {
        this.baseLength = baseLength;
        this.height = height;
    }

    public override double CalculateArea()
    {
        return baseLength * height / 2;
    }

    public override double CalculateVolume()
    {
        return CalculateArea();
    }
}

