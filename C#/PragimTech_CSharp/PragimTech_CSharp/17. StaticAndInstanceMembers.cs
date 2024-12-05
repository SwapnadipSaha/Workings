using System;

namespace StaticAndInstanceMembers
{

    class StaticAndInstanceMembers
    {
        static void Main17()
        {
            Console.Write("Enter Radius");
            int radius = Convert.ToInt32(Console.ReadLine());
            Circle c1 = new Circle(radius);
            Console.WriteLine("The Area is {0}", c1.CalcArea());
            Circle c2 = new Circle(6);
            Console.WriteLine("The Area is {0}", c2.CalcArea());
            Circle c3 = new Circle();
            Console.WriteLine("The Area is {0}", c3.CalcArea());
            Circle.Print(c1);
            Circle.Print(c2);
            Circle.Print(c3);
        }
    }

    class Circle
    {
        static float _pi;
        int _radius;

        public Circle() : this(0)
        {
            Console.WriteLine("ParameterLess Const");
        }

        public Circle(int Radius)
        {
            Console.WriteLine("Parameterwala Const");
            this._radius = Radius;
        }

        static Circle()
        {
            Console.WriteLine("Static const");
            Circle._pi = 3.141f;
        }
        public float CalcArea()
        {
            Console.WriteLine("Float Method");
            return _pi * this._radius * this._radius;  //or
                                                       //return Circle._pi * this._radius * this._radius;

        }

        public static void Print(Circle c)
        {
            Console.WriteLine("Static Method");
            Console.WriteLine("Perimeter is {0}", 2 * Circle._pi * c._radius);
        }
    }
}