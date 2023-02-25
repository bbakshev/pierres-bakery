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

      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("We sell delicious bread and pastries.");
      Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
      Console.WriteLine("| Bread: A single loaf costs $5                        | Pastry: A single pastry for $2                      |");
      Console.WriteLine("| Buy 2, get 1 free (every 3rd loaf of bread is free.) | Buy 3 get 1 free (every 4th pastry is free)         |");
      Console.WriteLine("-------------------------------------------------------------------------------------------------------------");

      Console.WriteLine("** Don't forget to add a cup of coffee with your order for $2.5 **");
      Console.ResetColor();

      Bread newBread = new Bread();
      Pastry newPastry = new Pastry();
      Coffee newCoffee = new Coffee();

      Console.WriteLine("How many loaves of bread would you like to order?");
      newBread.NumberOfLoaves = int.Parse((Console.ReadLine()));

      string coffeeInput;

      Console.WriteLine("Would you like to order some pastries? Enter 'yes' or 'no'");
      string inputPastry = Console.ReadLine().ToLower();

      if (inputPastry == "yes")
      {
        Console.WriteLine("How many pastries would you like to order?");
        newPastry.NumberOfPastries = int.Parse((Console.ReadLine()));

        Console.WriteLine("Would you like to order coffee? Enter 'yes' or 'no'");
        coffeeInput = Console.ReadLine().ToLower();

        if (coffeeInput == "yes")
        {
          Console.WriteLine("How many coffees would you like to order?");
          newCoffee.NumberOfCofees = int.Parse((Console.ReadLine()));

          double totalAmount = newBread.TotalCostBread() + newPastry.TotalCostPastry() + (double)newCoffee.TotalCostCoffee();
          Console.WriteLine("Your total amount is: $" + totalAmount);
        }

        else if (coffeeInput == "no")
        {
          double totalAmount = newBread.TotalCostBread() + newPastry.TotalCostPastry() + (double)newCoffee.TotalCostCoffee();
          Console.WriteLine("Your total amount is: $" + totalAmount);
        }
      }
      else if (inputPastry == "no")
      {
        Console.WriteLine("Would you like to order coffee? Enter 'yes' or 'no'");
        coffeeInput = Console.ReadLine().ToLower();
        if (coffeeInput == "yes")
        {
          Console.WriteLine("How many coffees would you like to order?");
          newCoffee.NumberOfCofees = int.Parse((Console.ReadLine()));
        }

        else
        {
          newCoffee.NumberOfCofees = 0;
        }
        double totalAmount = newBread.TotalCostBread() + newPastry.TotalCostPastry() + (double)newCoffee.TotalCostCoffee();
        Console.WriteLine("Your total amount is: $" + totalAmount);
      }
    }
  }
}