using System;

namespace BestProductFindsApi.Data
{
    public class Product
    {
      public int Id { get; set; }
      public string Name { get; set; }
      public decimal Price { get; set; }
      public string Description { get; set; }
      public string URL { get; set; }
      public DateTime CreateDate { get; set; }
      public Seller Seller { get; set; }
      public Category Category { get; set; }
    }
}