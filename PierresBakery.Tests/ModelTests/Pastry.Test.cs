using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Bread()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetUserInputForNumOfPastries_ItStoresUserInputAsProperty_Int()
    {
      Pastry newPastry = new Pastry();
      newPastry.NumberOfPastries = 3;
      Assert.AreEqual(3, newPastry.NumberOfPastries);
    }

    [TestMethod]
    public void CalculateTotalCostForASinglePastry_Int()
    {
      Pastry newPastry = new Pastry();
      newPastry.NumberOfPastries = 1;
      Assert.AreEqual(2, newPastry.TotalCostPastry());
    }

    [TestMethod]
    public void CalculateTotalCostForAMultiplePastries_Int()
    {
      Pastry newPastry = new Pastry();
      newPastry.NumberOfPastries = 8;
      Assert.AreEqual(12, newPastry.TotalCostPastry());
    }
  }
}