using Microsoft.AspNetCore.Mvc;
using DreamHomeApi.DTOs;
using DreamHomeApi.Models;
using DreamHomeApi.Services;

namespace DreamHomeApi.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class PrivateOwnerController : ControllerBase
{
    private readonly PrivateOwnerService _privateOwnerService;
    
    public PrivateOwnerController(PrivateOwnerService privateOwnerService)
    {
        _privateOwnerService = privateOwnerService;
    }
    
    // GET: api/PrivateOwner
    [HttpGet]
    public async Task<ActionResult<IEnumerable<PrivateOwner>>> Get()
    {
        var privateOwners = await _privateOwnerService.Get();
        if (privateOwners == null)
        {
            return NotFound();
        }

        return privateOwners.ToList();
    }
    
    // GET: api/PrivateOwner/5
    [HttpGet("{id}")]
    public async Task<ActionResult<PrivateOwner>> Get(int id)
    {
        var privateOwner = await _privateOwnerService.Get(id);
        if (privateOwner == null)
        {
            return NotFound();
        }

        return privateOwner;
    }
    
    // PUT: api/PrivateOwner/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, PrivateOwnerDto privateOwner)
    {
        var updatedPrivateOwner = await _privateOwnerService.Update(id, privateOwner);
        if (updatedPrivateOwner == null)
        {
            return NotFound();
        }
        
        return NoContent();
    }
    
    // POST: api/PrivateOwner
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<PrivateOwner>> Post(PrivateOwnerDto privateOwner)
    {
        var newPrivateOwner = await _privateOwnerService.Create(privateOwner);
        if (newPrivateOwner == null)
        {
            return BadRequest();
        }

        return CreatedAtAction(nameof(Get), new { id = newPrivateOwner.Id }, newPrivateOwner);
    }
    
    // DELETE: api/PrivateOwner/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var privateOwner = await _privateOwnerService.Get(id);
        if (privateOwner == null)
        {
            return NotFound();
        }
        
        await _privateOwnerService.Delete(id);
        return NoContent();
    }
}