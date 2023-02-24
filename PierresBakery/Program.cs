using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PierresBakery.Models;

namespace PierresBakery
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine(@"╦ ╦┌─┐┬  ┌─┐┌─┐┌┬┐┌─┐  ┌┬┐┌─┐  ╔═╗┬┌─┐┬─┐┬─┐┌─┐┌─┐  ╔╗ ┌─┐┬┌─┌─┐┬─┐┬ ┬
║║║├┤ │  │  │ ││││├┤    │ │ │  ╠═╝│├┤ ├┬┘├┬┘├┤ └─┐  ╠╩╗├─┤├┴┐├┤ ├┬┘└┬┘
╚╩╝└─┘┴─┘└─┘└─┘┴ ┴└─┘   ┴ └─┘  ╩  ┴└─┘┴└─┴└─└─┘└─┘  ╚═╝┴ ┴┴ ┴└─┘┴└─ ┴ ");
      Console.ResetColor();

      Console.WriteLine("We sell delicious bread for $5 per loaf and pastry for $2 per pastry.");
      Console.WriteLine("Our special deal: Buy 2 loaves, get 1 free! Buy 3 pastries, get 1 free!");
      Console.WriteLine("Don't forget to add a cup of coffee with your order for $2.5");

      Bread newBread = new Bread();
      Console.WriteLine("How many loaves of bread would you like to order?");
      newBread.NumberOfLoaves = int.Parse((Console.ReadLine()));
      
      Pastry newPastry = new Pastry();
      
    }
  }
}