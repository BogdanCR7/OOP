// See https://aka.ms/new-console-template for more information

public class Circle : IFigure
{
    public Circle(double Radius)
    {
        if (Radius < 0)
            throw new ArgumentOutOfRangeException("Радиус не может быть отрицательным");

        this.Radius = Radius;
    }

    public double Radius { get; }
    float IFigure.CalculateArea()
    {
        return (float)(Math.PI * Radius * Radius);
    }
}