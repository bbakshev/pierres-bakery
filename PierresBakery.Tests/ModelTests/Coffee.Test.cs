using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System;

namespace PierresBakery.Tests
{
  [TestClass]
  public class CoffeeTests
  {
    [TestMethod]
    public void CoffeeConstructor_CreatesInstanceOfCofee_Coffee()
    {
      Coffee newCoffee = new Coffee();
      Assert.AreEqual(typeof(Coffee), newCoffee.GetType());
    }

    [TestMethod]
    public void GetUserInputForNumOfCoffee_ItStoresUserInputAsProperty_Int()
    {
      Coffee newCoffee = new Coffee();
      newCoffee.NumberOfCofees = 2;
      Assert.AreEqual(2, newCoffee.NumberOfCofees);
    }

    [TestMethod]
    public void CalculateTotalCostForASingleCoffee_Decimal()
    {
      Coffee newCoffee = new Coffee();
      newCoffee.NumberOfCofees = 1;
      newCoffee.CostPerCoffee = 2.5m;
      Assert.AreEqual(2.5m, newCoffee.TotalCostCoffee());
    }
  }
}