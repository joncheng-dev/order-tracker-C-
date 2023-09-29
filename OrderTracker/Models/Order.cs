using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Order
  {
    public string Title { get; }
    public string Description { get; }

    public Order(string title, string description)
    {
      Title = title;
      Description = description; 
    }
  }
}