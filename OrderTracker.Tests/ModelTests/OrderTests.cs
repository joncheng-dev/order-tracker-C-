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
      Order instanceOfOrder = new Order("a title", "a description");
      Assert.AreEqual(typeof(Order), instanceOfOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      string formCollectedTitle = "Saturday Market Order";
      Order instanceOfOrder = new Order(formCollectedTitle, "a description");
      string resultFromGet = instanceOfOrder.Title;
      Assert.AreEqual(formCollectedTitle, resultFromGet);      
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string formCollectedTitle = "Saturday Market Order";
      string formCollectedDescription = "20 loaves of bread; pre-cut";
      Order instanceOfOrder = new Order(formCollectedTitle, formCollectedDescription);
      string resultFromGet = instanceOfOrder.Description;
      Assert.AreEqual(formCollectedDescription, resultFromGet);     
    }
  }
}