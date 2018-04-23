using System;

class Circle
{
    int _Radius;
    float _pi = 3.14F;
public Circle(int Radius)
    {
        this._Radius = Radius;
    }
public float AreaCircle()
    {
        return this._pi * this._Radius * this._Radius;
    }
    class Program
    {
        static void Main()
        {
            Circle C1 = new Circle(5);
            float Area = C1.AreaCircle();
            Console.WriteLine("Area is = {0}", Area);
            Console.ReadLine();
    
        }
    }
}
