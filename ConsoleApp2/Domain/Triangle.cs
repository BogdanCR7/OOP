// See https://aka.ms/new-console-template for more information

public class Triangle : IFigure
{
   
    public Triangle(float FirstSide, float SecondSide, float ThirdSide)
    {
        if (FirstSide < 0 || SecondSide < 0 || ThirdSide < 0 ||
        (FirstSide + SecondSide <= ThirdSide) || FirstSide + ThirdSide <= SecondSide ||
            SecondSide + ThirdSide <= FirstSide)
        {
            throw new ArgumentOutOfRangeException("Not a valid triangle");
        }

        this.FirstSide = FirstSide;
        this.SecondSide = SecondSide;
        this.ThirdSide = ThirdSide;
    }
    public float CalculateArea()
    {
        float s = (FirstSide + SecondSide + ThirdSide) / 2;
        return (float)Math.Sqrt(s * (s - FirstSide) *
                            (s - SecondSide) * (s - ThirdSide));
    }

     float FirstSide { get; set; }

     float SecondSide { get; set; }

     float ThirdSide { get; set; }

    public bool CheckIsRightAngled()
    {
        double MaxSide = new[] { FirstSide, SecondSide, ThirdSide }.Max();
        var maxSideSqr = MaxSide * MaxSide;
        return maxSideSqr + maxSideSqr == FirstSide * FirstSide + SecondSide * SecondSide + ThirdSide * ThirdSide;
    }

}