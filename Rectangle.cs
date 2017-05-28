using System;
class Rectangle
{
  double length;
  double width;
  public void AcceptDetails(double l, double w)
  {
     length = l;
     width = w;
  }

  public double GetArea()
  {
     return length * width;
  }

  public void Display()
  {
     Console.WriteLine("Length: {0}", length);
     Console.WriteLine("Width: {0}", width);
     Console.WriteLine("Area: {0}", GetArea());
  }
}

class ExecuteRectangle
{
  static void Main(string[] args)
  {
     Rectangle r = new Rectangle();
     double length;
     double width;
     try
     {
       length = Double.Parse(args[0]);
       width = Double.Parse(args[1]);
       r.AcceptDetails(length, width);
       r.Display();
     }
     catch (IndexOutOfRangeException)
     {
       Console.WriteLine("Invalid input arguments found!");
     }
     catch (FormatException)
     {
       Console.WriteLine("Only numbers are accepted!");
     }
  }
}
