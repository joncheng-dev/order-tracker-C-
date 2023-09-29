using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Vendor
  {
    public string Name { get; }
    public string Description { get; }

    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
    }
  }
}