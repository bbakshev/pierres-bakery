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
  }
}