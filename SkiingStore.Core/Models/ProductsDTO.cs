// Libraries Namespaces
using System.Collections.Generic;

namespace SkiingStore.Core.Models
{
  public class ProductsDTO
  {
    public int TotalItems { get; set; }
    public int PageNumber { get; set; }
    public List<Product> Products { get; set; }
  }
}
