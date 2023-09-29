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
  }
}