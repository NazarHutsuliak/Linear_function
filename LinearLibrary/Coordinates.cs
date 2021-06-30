namespace LinearLibrary
{
    public class Coordinates
    {
        public double X1 { get; }
        public double Y1 { get; }
        public double X2 { get; }
        public double Y2 { get; }

        public Coordinates(double x1, double y1, double x2, double y2)
        {
            Y1 = y1;
            Y2 = y2;
            X1 = x1;
            X2 = x2;
        }
    }
}