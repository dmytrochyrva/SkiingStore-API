// Libraries Namespaces
using System;
using System.Linq;
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
    public async Task<ActionResult<List<Product>>> GetProducts(float priceFrom, float priceTo, string category)
    {
      var products = await this._skiingDbContext.Products
        .Where(product => priceFrom == 0 || product.Price >= priceFrom)
        .Where(product => priceTo == 0 || product.Price <= priceTo)
        .Where(product => String.IsNullOrEmpty(category) || product.Category == category)
        .ToListAsync();

      return products;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Product>> GetProdutById(string id)
    {
      var product = await this._skiingDbContext.Products.FindAsync(id);

      return product == null
        ? NotFound("There is no product with this id")
        : product;
    }

    [HttpGet]
    [Route("categories")]
    public async Task<ActionResult<List<Category>>> GetCategories()
    {
      var categories = await this._skiingDbContext.Categories.ToListAsync();

      return categories;
    }
  }
}