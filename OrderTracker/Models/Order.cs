using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Order
  {
    public string Title { get; }

    public Order(string title)
    {
      Title = title;
      // Description = description; 
    }
  }
}