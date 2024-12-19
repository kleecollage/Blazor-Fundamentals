using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components.Forms;

namespace Fundamentals.Models;

public class Product
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Product name is required")]
    public string Name { get; set; }
    
    public string Description { get; set; }
    
    [Range(0.01, 9999.99, ErrorMessage = "Price range must be between 0.01 and 9999.99")]
    public decimal Price { get; set; }   
    
    [Range(1, 1000, ErrorMessage = "Stock range must be between 1 and 1000")]
    public int Stock { get; set; }
    
    public DateTime ReleaseDate { get; set; }
    
    [Required(ErrorMessage = "Category is required")]
    public string Category { get; set; }
    
    public bool Available { get; set; }

    [Url(ErrorMessage = "Invalid URL")]
    public string ImageUrl { get; set; }

    public string FileName { get; set; }
    
    /* CASCADE SELECTOR */
    public int Selector1 { get; set; }
    public int Selector2 { get; set; }
}