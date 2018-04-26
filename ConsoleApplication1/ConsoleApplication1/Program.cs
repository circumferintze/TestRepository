using System;

class Circle
{
    int _Radius;
   static float _pi;
    static Circle()
    {
        Circle._pi = 3.14F;
    }
        public Circle(int Radius)
    {
        this._Radius = Radius;
    }
public float AreaCircle()
    {
        return Circle._pi * this._Radius * this._Radius;
    }
    class Program
    {
        static void Main()
        {
            Circle C1 = new Circle(5);
            float Area1 = C1.AreaCircle();
            Console.WriteLine("Area is = {0}", Area1);
          

            Circle C2 = new Circle(6);
            float Area2 = C2.AreaCircle();
            Console.WriteLine("Area is = {0}", Area2);
            Console.ReadLine();

        }
    }
}
