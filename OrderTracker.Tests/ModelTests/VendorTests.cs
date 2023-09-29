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
  }
}