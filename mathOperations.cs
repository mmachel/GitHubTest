using System;

namespace Operations
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to calculus basic Operations");
      printInfo(Addition(32.0,64.0));
    }
  }
  public static double Addition(double x, double y)
  {
    return x + y;
  }
  public static double Mult(double x, double y)
  {
    return x*y;
  }
  public static void printInfo(double result)
  {
    Console.WriteLine("The result of the operation is "+result);
  }
}
