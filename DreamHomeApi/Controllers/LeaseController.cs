using Microsoft.AspNetCore.Mvc;
using DreamHomeApi.DTOs;
using DreamHomeApi.Models;
using DreamHomeApi.Services;

namespace DreamHomeApi.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class LeaseController : ControllerBase
{
    private readonly LeaseService _leaseService;

    public LeaseController(LeaseService leaseService)
    {
        _leaseService = leaseService;
    }
    
    // GET: api/Lease
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Lease>>> Get()
    {
        var leases = await _leaseService.Get();
        if (leases == null)
        {
            return NotFound();
        }

        return leases.ToList();
    }
    
    // GET: api/Lease/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Lease>> Get(int id)
    {
        var lease = await _leaseService.Get(id);
        if (lease == null)
        {
            return NotFound();
        }

        return lease;
    }
    
    // PUT: api/Lease/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, LeaseDto lease)
    {
        var updatedLease = await _leaseService.Update(id, lease);
        if (updatedLease == null)
        {
            return NotFound();
        }
        
        return NoContent();
    }
    
    // POST: api/Lease
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<Lease>> Post(LeaseDto lease)
    {
        var newLease = await _leaseService.Create(lease);
        if (newLease == null)
        {
            return BadRequest();
        }

        return CreatedAtAction(nameof(Get), new { id = newLease.Id }, newLease);
    }
    
    // DELETE: api/Lease/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var lease = await _leaseService.Get(id);
        if (lease == null)
        {
            return NotFound();
        }

        await _leaseService.Delete(lease.Id);
        return NoContent();
    }
}