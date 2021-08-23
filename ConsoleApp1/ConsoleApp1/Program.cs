using System;
using MyArrayLibrary;

namespace ConsoleApp1
{
  class Program 
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello, world!");
      int[] array = new int[5] { 1, 3, 2, 4, 5 };
      MyArray.addToStart(ref array);
      foreach (var item in array)
      {
        Console.WriteLine(item);
      }
      Console.ReadLine();

    }
  }
}
