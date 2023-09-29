using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using OrderTracker.Models;

namespace OrderTracker.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string enteredName, string enteredDescription)
    {
      Vendor justAddedInstanceOfVendor = new Vendor(enteredName, enteredDescription);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Vendor searchAndFoundVendor = Vendor.Find(id);
      Dictionary<string, object> sendToView = new Dictionary<string, object>();
      List<Order> correspondingListOfOrders = searchAndFoundVendor.Orders;
      sendToView.Add("vendor", searchAndFoundVendor);
      sendToView.Add("orders", correspondingListOfOrders);
      return View(sendToView);
    }

  }
}