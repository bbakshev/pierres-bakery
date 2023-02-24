using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetUserInputForNumOfLoaves_ItStoresUserInputAsProperty_Int()
    {
      Bread newBread = new Bread();
      newBread.NumberOfLoaves = 5;
      Assert.AreEqual(5, newBread.NumberOfLoaves);
    }

    [TestMethod]
    public void CalculateTotalCostForASingleLoaf_Int()
    {
      Bread newBread = new Bread();
      newBread.NumberOfLoaves = 1;
      Assert.AreEqual(5, newBread.TotalCost());
    }
  }
}