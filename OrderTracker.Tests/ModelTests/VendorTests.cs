using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using OrderTracker.Models;

namespace OrderTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendorClass_Vendor()
    {
      string inputtedVendorName = "Sloppy Joe's Extraordinary Peanut Butter Sandwiches";
      string inputtedVendorDescription = "A local sandwich shop revitalizing the time-tested peanut butter sandwich.";
      Vendor justAddedInstance = new Vendor(inputtedVendorName, inputtedVendorDescription);
      Assert.AreEqual(typeof(Vendor), justAddedInstance.GetType());
    }

    [TestMethod]
    public void GetStringFields_ReturnsNameAndDescriptionSeparately_String()
    {
      string inputtedVendorName = "Sloppy Joe's Extraordinary Peanut Butter Sandwiches";
      string inputtedVendorDescription = "A local sandwich shop revitalizing the time-tested peanut butter sandwich.";
      Vendor justAddedInstance = new Vendor(inputtedVendorName, inputtedVendorDescription);
      // Results of Using Getter
      string vendorNameUsingGetter = justAddedInstance.Name;
      string vendorDescUsingGetter = justAddedInstance.Description;
      // Assert
      Assert.AreEqual(inputtedVendorName, vendorNameUsingGetter);
      Assert.AreEqual(inputtedVendorDescription, vendorDescUsingGetter);
    }

    [TestMethod]
    public void GetId_ReturnsId_Int()
    {
      int justAddedInstancesId = 1;
      string inputtedVendorName = "Sloppy Joe's Extraordinary Peanut Butter Sandwiches";
      string inputtedVendorDescription = "A local sandwich shop revitalizing the time-tested peanut butter sandwich.";
      Vendor justAddedInstance = new Vendor(inputtedVendorName, inputtedVendorDescription);
      int idResultFromGetter = justAddedInstance.Id;
      Assert.AreEqual(justAddedInstancesId, idResultFromGetter);
    }

    [TestMethod]
    public void GetAll_ReturnsAllInstancesOfVendorObjects_List()
    {
      string inputtedVendorName1 = "Sloppy Joe's Extraordinary Peanut Butter Sandwiches";
      string inputtedVendorDescription1 = "A local sandwich shop revitalizing the time-tested peanut butter sandwich.";
      Vendor justAddedInstance1 = new Vendor(inputtedVendorName1, inputtedVendorDescription1);
      string aSecondVendorName = "Geno's Groovy Gelato Shoppe";
      string aSecondVendorDesc = "A mom and pop dessert shop bringing you quality gelato paired with scrumptious pastries.";
      Vendor a2ndVendorInstance = new Vendor(aSecondVendorName, aSecondVendorDesc);
      List<Vendor> allCurrentVendors = new List<Vendor> { justAddedInstance1, a2ndVendorInstance };
      List<Vendor> retrievedVendors = Vendor.GetAll();
      CollectionAssert.AreEqual(allCurrentVendors, retrievedVendors);
    }

    [TestMethod]
    public void Find_ReturnsVendorWithSpecifiedId_Vendor()
    {
      string inputtedVendorName1 = "Sloppy Joe's Extraordinary Peanut Butter Sandwiches";
      string inputtedVendorDescription1 = "A local sandwich shop revitalizing the time-tested peanut butter sandwich.";
      Vendor justAddedInstance1 = new Vendor(inputtedVendorName1, inputtedVendorDescription1);
      string aSecondVendorName = "Geno's Groovy Gelato Shoppe";
      string aSecondVendorDesc = "A mom and pop dessert shop bringing you quality gelato paired with scrumptious pastries.";
      Vendor a2ndVendorInstance = new Vendor(aSecondVendorName, aSecondVendorDesc);
      int idOfVendorTargetted = 2;
      Vendor idSearchReturnedVendor = Vendor.Find(idOfVendorTargetted);
      Assert.AreEqual(a2ndVendorInstance, idSearchReturnedVendor);      
    }

    [TestMethod]
    public void AddOrder_AssociatesOrdersWithVendorInstance_OrderList()
    {
      // Create instance of Vendor
      string inputtedVendorName = "Sloppy Joe's Extraordinary Peanut Butter Sandwiches";
      string inputtedVendorDescription = "A local sandwich shop revitalizing the time-tested peanut butter sandwich.";
      Vendor aVendorInstance = new Vendor(inputtedVendorName, inputtedVendorDescription);
      // Create 2 instances of Order
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
      // Make dummy list to compare to.
      List<Order> dummyListOfOrders = new List<Order> { order1, order2 };
      // Add orders to list in instance of Vendor class
      aVendorInstance.AddOrder(order1);
      aVendorInstance.AddOrder(order2);
      List<Order> resultingListOfAddOrderMethod = aVendorInstance.Orders;
      CollectionAssert.AreEqual(dummyListOfOrders, resultingListOfAddOrderMethod);
    }
  }
}