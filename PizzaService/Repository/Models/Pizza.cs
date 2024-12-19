using System.ComponentModel.DataAnnotations;

namespace Repository.Models;

public class Pizza
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Ingredients { get; set; }
    public decimal Price { get; set; }

}