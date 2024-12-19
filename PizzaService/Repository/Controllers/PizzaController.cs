using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Models;


[ApiController]
[Route("api/[controller]")]
public class PizzaController : ControllerBase
{
    private readonly PizzaContext _context;
    
    public PizzaController(PizzaContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Pizza>>> GetPizzas()
    {
        return await _context.Pizzas.ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<Pizza>> CreatePizza(Pizza pizza)
    {
        _context.Pizzas.Add(pizza);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetPizzas), new { id = pizza.Id }, pizza);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, Pizza pizza)
    {
        var existingPizza = await _context.Pizzas.FindAsync(id);
        if (existingPizza == null) return NotFound();

        existingPizza.Name = pizza.Name;
        existingPizza.Price = pizza.Price;
        existingPizza.Ingredients = pizza.Ingredients;

        await _context.SaveChangesAsync();

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var pizza = await _context.Pizzas.FindAsync(id);
        if (pizza == null) return NotFound();

        _context.Pizzas.Remove(pizza);
        await _context.SaveChangesAsync();

        return NoContent();


    }
}
