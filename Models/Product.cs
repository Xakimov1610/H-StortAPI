using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace HP_SportAPI.Models;

public class Product
{
    public int Id { get; set; }
    [Required]
    public string Sku { get; set; } = string.Empty;
    [Required]
    public string Name { get; set; } = string.Empty;
    [Required]
    public string Description { get; set; } = string.Empty;
    [Required]
    public decimal Price { get; set; }
    [Required]
    public bool IsAvailable { get; set; }


    [Required]
    public int CategoryId { get; set; }
    
    [JsonIgnore]
    public virtual Category Category { get; set; }

}

