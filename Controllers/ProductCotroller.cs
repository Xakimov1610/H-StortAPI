namespace H_SportAPI.Models;

using HP_SportAPI.Models;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly ShopContext _context;

    public ProductController(ShopContext context)
    {
        _context = context;

        _context.Database.EnsureCreated();
    }

    [HttpGet]
    public IActionResult GetAllProducts()
    {
        return Ok(_context.Products.ToArray());
    }
    
    [HttpGet("{id}")]
    public IActionResult GetProduct(int id)
    {
        var product = _context.Products.Find(id);

        if (product == null)
        {
            return NotFound();
        }

        return Ok(product);
    }
}