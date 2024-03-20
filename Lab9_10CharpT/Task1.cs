using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_10CharpT
{
    public class InvalidException : Exception
    {
        public InvalidException(string message) : base(message) { }
    }

    abstract class Figure
    {
        public abstract double calculationArea();
        public abstract double calculationPerimetr();
        public virtual void Show()
        {
            Console.WriteLine("Base Figure");
        }
    }
    class Rectangle : Figure
    {
        public double a
        {
            get
            {
                return a;
            }
            set
            {
                if (value <= 0)
                    throw new InvalidException("Довжина не може бути вiд'ємна. ");
                a = value;
            }
        }
        public double b
        {
            get
            {
                return b;
            }
            set
            {
                if (value <= 0)
                    throw new InvalidException("Ширина не може бути вiд'ємна. ");
                b = value;
            }
        }

        public Rectangle()
        {
            this.a = 0;
            this.b = 0;
        }
        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public override double calculationArea()
        {
            return a * b;
        }
        public override double calculationPerimetr()
        {
            return 2 * (a + b);
        }
        public override void Show()
        {
            Console.WriteLine($"Rectangle: a = {a}; b = {b}; S = {calculationArea()}; P = {calculationPerimetr()};");
        }
    }
    class Circle : Figure
    {
        public double r
        {
            get
            {
                return r;
            }
            set
            {
                if (value <= 0)
                    throw new InvalidException("Радiус не може бути вiд'ємний. ");
                r = value;
            }
        }
        public Circle()
        {
            this.r = 0;
        }
        public Circle(double r)
        {
            this.r = r;
        }
        public override double calculationArea()
        {
            return r * r * Math.PI;
        }
        public override double calculationPerimetr()
        {
            return 2 * r * Math.PI;
        }
        public override void Show()
        {
            Console.WriteLine("Circle: radius = {0}; S = {1}; P = {2};",
                r, calculationArea(), calculationPerimetr());
        }
    }
    class Triangle : Figure
    {
        public double AB
        {
            get
            {
                return AB;
            }
            set
            {
                if (value <= 0)
                    throw new InvalidException("Сторона АВ не може бути вiд'ємна. ");
                AB = value;
            }
        }
        public double BC
        {
            get
            {
                return BC;
            }
            set
            {
                if (value <= 0)
                    throw new InvalidException("Сторона BC не може бути вiд'ємна. ");
                BC = value;
            }
        }
        public double AC
        {
            get
            {
                return AC;
            }
            set
            {
                if (value <= 0)
                    throw new InvalidException("Сторона AC не може бути вiд'ємна. ");
                AC = value;
            }
        }
        public Triangle()
        {
            this.AB = 0;
            this.BC = 0;
            this.AC = 0;
        }
        public Triangle(double AB, double BC, double AC)
        {
            this.AB = AB;
            this.BC = BC;
            this.AC = AC;
        }
        public override double calculationArea()
        {
            double p = ((AB + BC + AC) / 2);
            return Math.Sqrt(p * (p - AB) * (p - BC) * (p - AC));
        }
        public override double calculationPerimetr()
        {
            return AB + BC + AC;
        }
        public override void Show()
        {
            Console.WriteLine($"Triangle: AB = {AB}; BC = {BC}; AC = {AC}; S = {calculationArea()}; P = {calculationPerimetr()};");
        }
    }
}
