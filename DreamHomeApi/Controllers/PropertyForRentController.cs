using Microsoft.AspNetCore.Mvc;
using DreamHomeApi.DTOs;
using DreamHomeApi.Models;
using DreamHomeApi.Services;

namespace DreamHomeApi.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class PropertyForRentController : ControllerBase
{
    private readonly PropertyForRentService _propertyForRentService;

    public PropertyForRentController(PropertyForRentService propertyForRentService)
    {
        _propertyForRentService = propertyForRentService;
    }

    // GET: api/PropertyForRent
    [HttpGet]
    public async Task<ActionResult<IEnumerable<PropertyForRent>>> Get()
    {
        var properties = await _propertyForRentService.Get();
        if (properties == null)
        {
            return NotFound();
        }

        return properties.ToList();
    }

    // GET: api/PropertyForRent/5
    [HttpGet("{id}")]
    public async Task<ActionResult<PropertyForRent>> Get(int id)
    {
        var property = await _propertyForRentService.Get(id);
        if (property == null)
        {
            return NotFound();
        }

        return property;
    }

    // PUT: api/PropertyForRent/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, PropertyForRentDto property)
    {
        var updatedProperty = await _propertyForRentService.Update(id, property);
        if (updatedProperty == null)
        {
            return NotFound();
        }
        
        return NoContent();
    }

    // POST: api/PropertyForRent
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<PropertyForRent>> Post(PropertyForRentDto property)
    {
        var createdProperty = await _propertyForRentService.Create(property);
        if (createdProperty == null)
        {
            return NotFound();
        }
        
        return CreatedAtAction("Get", new { id = createdProperty.Id }, createdProperty);
    }

    // DELETE: api/PropertyForRent/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var property = await _propertyForRentService.Get(id);
        if (property == null)
        {
            return NotFound();
        }
        
        await _propertyForRentService.Delete(id);
        return NoContent();
    }
}