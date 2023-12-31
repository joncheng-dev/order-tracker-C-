using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using OrderTracker.Models;

namespace OrderTracker.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor targetVendor = Vendor.Find(vendorId);
      return View(targetVendor);
    }

    [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Order targetOrder = Order.Find(orderId);
      Vendor targetVendor = Vendor.Find(vendorId);
      Dictionary<string, object> dataToSend = new Dictionary<string, object>();
      dataToSend.Add("vendor", targetVendor);
      dataToSend.Add("order", targetOrder);
      return View(dataToSend);
    }
  }
}