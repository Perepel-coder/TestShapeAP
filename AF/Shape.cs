namespace AF
{

    public abstract class IShape
    {
        protected double P = 3.14;
        public abstract double GetArea();
        public abstract double GetPerimeter();
    }

    public class Circle: IShape
    {
        public double Radius { get; private set; }
        public Circle(double radius)
        {
            if(radius <= 0) { throw new Exception("Радиус меньше или равен 0"); }
            this.Radius = radius;
        }

        public override double GetArea()
        {
            return Radius * Radius * P;
        }

        public override double GetPerimeter()
        {
            return 2 * Radius * P;
        }
    }
    public class Triangle : IShape
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }
        public Triangle(double a, double b, double c)
        {
            if (a >= b + c || b >= a + c || c >= a + b
                || a <= 0 || b <= 0 || c <= 0) 
            { 
                throw new Exception("Не выполняется теорема о неравенстве треугольника"); 
            }
            this.A = a;
            this.B = b;
            this.C = c;
        }
        public override double GetArea()
        {
            double p = GetPerimeter() / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public override double GetPerimeter()
        {
            return A + B + C;
        }
        public bool IsRightTriangle()
        {
            if (A * A + B * B == C * C || A * A + C * C == B * B || B * B + C * C == A * A)
            {
                return true;
            }
            return false;
        }
    }
}