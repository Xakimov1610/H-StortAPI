namespace H_SportAPI.Models;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class ProductContoller : ControllerBase
{
    [HttpGet, Route("HELLO")]
    public string Get()
    {
        return "Hello World";
    }
}