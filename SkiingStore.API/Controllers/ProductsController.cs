// Libraries Namespaces
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// Local Namespace
using SkiingStore.Core.Models;
using SkiingStore.Infrastructure.Data;

namespace SkiingStore.API.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class ProductsController : ControllerBase
  {
    private readonly SkiingStoreDb _skiingDbContext;

    public ProductsController(SkiingStoreDb skiingStoreDb)
    {
      _skiingDbContext = skiingStoreDb;
    }

    [HttpGet]
    public async Task<ActionResult<List<Product>>> GetProducts()
    {
      var products = await this._skiingDbContext.Products.ToListAsync();

      return products;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Product>> GetProdutById(string id)
    {
      var product = await this._skiingDbContext.Products.FindAsync(id);

      return product;
    }
  }
}