namespace Day4
{
    public abstract class Figure
    {

        
            public double Width, Height, Radius;
            public const float Pi = 3.14f;
            public abstract double GetArea();
        
    }

        public class Rectangle : Figure
        {
            public Rectangle(double Width, double Height)
            {
                this.Width = Width;
                this.Height = Height;
            }

            public override double GetArea()
            {

                return Width * Height;
            }

        }

        public class Circle :Figure
        {
            public Circle(double Radius)
            {
                this.Radius = Radius;
            }

            public override double GetArea()
            {
                return Radius*Pi*Radius;
            }
        }

        public class Cone : Figure
        {
            public Cone(double Radius, double Height)
            {
                this.Radius=Radius;
                this.Height=Height;

            }

            public override double GetArea()
            {
                return Pi*Radius*(Radius+ Math.Sqrt(Height*Height + Radius*Radius));
            }

        }
        
    

    class TestFigure
{

        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(12.67, 56.78);
            Circle c = new Circle(2);
            Cone cn = new Cone(34.56, 43.56);

            Console.WriteLine("Area of Reactangle is " + r.GetArea());
            Console.WriteLine("Area of Circle is " + r.GetArea());
            Console.WriteLine("Area of Cone " + cn.GetArea());


        }

    }
}
