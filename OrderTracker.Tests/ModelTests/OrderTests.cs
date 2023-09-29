using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using OrderTracker.Models;
using System;

namespace OrderTracker.Tests
{

  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order instanceOfOrder = new Order("a title", "a description", 100, "a date");
      Assert.AreEqual(typeof(Order), instanceOfOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      string formCollectedTitle = "Saturday Market Order";
      Order instanceOfOrder = new Order(formCollectedTitle, "a description", 100, "a date");
      string resultFromGet = instanceOfOrder.Title;
      Assert.AreEqual(formCollectedTitle, resultFromGet);      
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string formCollectedTitle = "Saturday Market Order";
      string formCollectedDescription = "20 loaves of bread; pre-cut";
      Order instanceOfOrder = new Order(formCollectedTitle, formCollectedDescription, 100, "a date");
      string resultFromGet = instanceOfOrder.Description;
      Assert.AreEqual(formCollectedDescription, resultFromGet);     
    }

    [TestMethod]
    public void GetPrice_ReturnsPrice_Int()
    {
      string formCollectedTitle = "Saturday Market Order";
      string formCollectedDescription = "20 loaves of bread; pre-cut";
      int formCollectedPrice = 200;
      Order instanceOfOrder = new Order(formCollectedTitle, formCollectedDescription, formCollectedPrice, "a date");
      int resultFromGet = instanceOfOrder.Price;
      Assert.AreEqual(formCollectedPrice, resultFromGet);     
    }

    [TestMethod]
    public void GetDate_ReturnsDate_String()
    {
      string formCollectedTitle = "Saturday Market Order";
      string formCollectedDescription = "20 loaves of bread; pre-cut";
      int formCollectedPrice = 200;
      string formCollectedDate = "Sept 29, 2023";
      Order instanceOfOrder = new Order(formCollectedTitle, formCollectedDescription, formCollectedPrice, formCollectedDate);
      string resultFromGet = instanceOfOrder.Date;
      Assert.AreEqual(formCollectedDate, resultFromGet);          
    }

    [TestMethod]
    public void SetProperties_SetsTitleDescriptionPriceDateIndividually_Void()
    {
      string modifiedTitle = "County Fair Order";
      string modifiedDescription = "200 loaves of bread; pre-cut";
      int modifiedPrice = 2000;
      string modifiedDate = "Oct 29, 2023";
      Order instanceOfOrder = new Order(modifiedTitle, modifiedDescription, modifiedPrice, modifiedDate);
      // Modified via Setter
      instanceOfOrder.Title = modifiedTitle;
      instanceOfOrder.Description = modifiedDescription;
      instanceOfOrder.Price = modifiedPrice;
      instanceOfOrder.Date = modifiedDate;
      // Check if they are equal
      Assert.AreEqual(modifiedTitle, instanceOfOrder.Title);       
      Assert.AreEqual(modifiedDescription, instanceOfOrder.Description);       
      Assert.AreEqual(modifiedPrice, instanceOfOrder.Price);       
      Assert.AreEqual(modifiedDate, instanceOfOrder.Date);       
    }

    [TestMethod]
    public void GetAllOrders_ReturnsEmptyList_OrderList()
    {
      List<Order> aList = new List<Order> { };
      List<Order> resultOfGetAll = Order.GetAllOrders();
      CollectionAssert.AreEqual(aList, resultOfGetAll);
    }

    [TestMethod]
    public void GetAllOrders_ReturnsAllOrders_OrderList()
    {
      // Set up and create two instances of orders
      string order1Title = "Saturday Market Order";
      string order1Description = "20 loaves of bread; pre-cut";
      int order1Price = 200;
      string order1Date = "Sept 29, 2023";
      Order order1 = new Order(order1Title, order1Description, order1Price, order1Date);
      string order2Title = "Boy Scouts Fund Raiser";
      string order2Description = "300 pastries";
      int order2Price = 500;
      string order2Date = "Oct 14, 2023";
      Order order2 = new Order(order2Title, order2Description, order2Price, order2Date);
      // Add to list
      List<Order> aList = new List<Order> { order1, order2 };
 
      List<Order> resultOfGetAll = Order.GetAllOrders();
      CollectionAssert.AreEqual(aList, resultOfGetAll);
    }

  }
}