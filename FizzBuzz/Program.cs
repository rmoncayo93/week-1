using System;

namespace FizzBuzz
{
  class Program
  {
    //takes the place of a config file
    static int start = 0;
    static int end = 100;
    static int div1 = 3;
    static int div2 = 5;
    static void Main(string[] args)
    {
      RunFizzBuzz(start, end);
      GetBoundsFromUserInput();
    }
    private static void GetBoundsFromUserInput()
    {
      Console.WriteLine("Lower bound for range:");
      Console.ReadLine();
    }
    // allow the user to give us upperBound, lowerBound (think validate)
    // allow the user to set condition for multiple
    // count from 0 to 100, and print each number per line
    // if number is multiple of 3, print fizz
    // if number is multiple of 5, print buzz
    // if number multiple of both, print fizzbuzz
    private static void RunFizzBuzz(int start, int end, int inc = 1)
    {
      // loop
      for (int i = start; i <= end; i += inc)
      {
        PrintNumber(i, div1, div2);
      }
    }
    private static void PrintNumber(int a, int div1, int div2)
    {
      // algorithm
      if (a == 0)
      {
        WriteToConsole(a.ToString());
        return;
      }
      if (a % (div1 * div2) == 0)
      {
        WriteToConsole("fizzbuzz");
      }
      else if (a % div1 == 0)
      {
        WriteToConsole("fizz");
      }
      else if (a % div2 == 0)
      {
        WriteToConsole("buzz");
      }
      else
      {
        WriteToConsole(a.ToString());
      }

    }
    private static void WriteToConsole(string toPrint)
    {
      // print to screen
      Console.WriteLine(toPrint);
    }
  }
}
