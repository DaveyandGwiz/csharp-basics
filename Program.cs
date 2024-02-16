using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello, I\'m a calculator!");
      Console.WriteLine("Enter a number:");
      int a = Convert.ToInt32(Console.ReadLine());      
      Console.WriteLine("Enter another number:");
      int b = Convert.ToInt32(Console.ReadLine());      
      int sum = a + b;
      Console.WriteLine(sum); // Print the sum of x + y    
    }
  }
}