using System;

namespace Part20StaticKeyword
{
    class Circle
    {
        float _pi;
        int _radius;
        public Circle(int radius)
        {
            this._pi = 3.141f;
            this._radius = radius;

        }
        public void AreaOfCircle()
        {
            Console.WriteLine("You Enterd Radius :{0}", this._radius);
            Console.WriteLine("Area of Circle is ={0}", this._pi * this._radius * this._radius);

        }
    }
 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To Calculate Area Of Circle ");
            Console.WriteLine("Plese Enter the Readius:");
            int radius = int.Parse(Console.ReadLine());
            Circle c = new Circle(radius);
            c.AreaOfCircle();
        }
    }

}
