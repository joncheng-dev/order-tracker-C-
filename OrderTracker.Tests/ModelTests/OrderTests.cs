using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using OrderTracker.Models;
using System;

namespace OrderTracker.Tests
{

  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order instanceOfOrder = new Order("some title");
      Assert.AreEqual(typeof(Order), instanceOfOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      string formCollectedTitle = "Saturday Market Order";
      Order instanceOfOrder = new Order(formCollectedTitle);
      string resultFromGet = instanceOfOrder.Title;
      Assert.AreEqual(formCollectedTitle, resultFromGet);      
    }
  }
}