// using System;
using sc = System.Console;

namespace Revature.Week1.HelloWorld // namespace scope
{
  //class, struct, interface, enum only scopes available to the namespace

  class Program // class scope
  {
    private static void Main() // method scope
    {
      sc.WriteLine("enter your name:");
      // stdin to get your name
      //   string in;
      var input = System.Console.ReadLine(); // datatype inference
                                             //   object fred2 = System.Console.ReadLine(); // anonymous datatype. object is not a datatype, c# will have to figure out the datatype at runtime
                                             // stdout the print your name
                                             //   System.Console.WriteLine("Hello " + input);
      sc.WriteLine($"Hello my name is {input}"); // string interpolation, template string
    }
    private void UiPath()
    {
      { // block scope

      }

      {

      }
    }
  }
}