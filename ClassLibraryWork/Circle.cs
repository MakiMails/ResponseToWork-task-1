namespace ClassLibraryWork
{
    public class Circle : Figure
    {
        private double _r;

        public Circle(double r)
        {
            _r = r;
        }

        public override double GetSquare()
        {
            return CalculateArea();
        }

        private double CalculateArea()
        {
            return Math.PI * _r * _r;
        }
    }
}
