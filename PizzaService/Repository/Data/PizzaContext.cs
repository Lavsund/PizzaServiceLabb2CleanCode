using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Repository.Models;

namespace Repository.Data;

public class PizzaContext : DbContext
{
    public PizzaContext(DbContextOptions<PizzaContext> options) : base(options)
    {
        
    }
    public DbSet<Pizza> Pizzas { get; set; }
}