namespace ClassLibraryWork
{
    public class Triangle : Figure
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public bool IsTriangleRectangular()
        {
            return (_sideC * _sideC) == (_sideA * _sideA) + (_sideB * _sideB);
        }

        public override double GetSquare()
        {
            return CalculateArea();
        }

        private double CalculateArea()
        {
            double p = (_sideA + _sideB + _sideC) / 2;
            return Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
        }
    }
}
