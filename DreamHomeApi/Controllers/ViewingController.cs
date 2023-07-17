using Microsoft.AspNetCore.Mvc;
using DreamHomeApi.DTOs;
using DreamHomeApi.Models;
using DreamHomeApi.Services;

namespace DreamHomeApi.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class ViewingController : ControllerBase
{
    private readonly ViewingService _viewingService;
    
    public ViewingController(ViewingService viewingService)
    {
        _viewingService = viewingService;
    }
    
    // GET: api/Viewing
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Viewing>>> Get()
    {
        var viewings = await _viewingService.Get();
        if (viewings == null)
        {
            return NotFound();
        }

        return viewings.ToList();
    }
    
    // GET: api/Viewing/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Viewing>> Get(int id)
    {
        var viewing = await _viewingService.Get(id);
        if (viewing == null)
        {
            return NotFound();
        }

        return viewing;
    }
    
    // PUT: api/Viewing/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, ViewingDto viewing)
    {
        var updatedStaff = await _viewingService.Update(id, viewing);
        if (updatedStaff == null)
        {
            return NotFound();
        }
        
        return NoContent();
    }
    
    // POST: api/Viewing
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<Viewing>> Post(ViewingDto viewing)
    {
        await _viewingService.Create(viewing);
        return CreatedAtAction("Get", new { id = viewing.Id }, viewing);
    }
    
    // DELETE: api/Viewing/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var viewing = await _viewingService.Get(id);
        if (viewing == null)
        {
            return NotFound();
        }
        
        await _viewingService.Delete(id);
        return NoContent();
    }
}