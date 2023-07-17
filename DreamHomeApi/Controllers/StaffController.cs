using Microsoft.AspNetCore.Mvc;
using DreamHomeApi.DTOs;
using DreamHomeApi.Models;
using DreamHomeApi.Services;

namespace DreamHomeApi.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class StaffController : ControllerBase
{
    private readonly StaffService _staffService;
    
    public StaffController(StaffService staffService)
    {
        _staffService = staffService;
    }
    
    // GET: api/Staff
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Staff>>> Get()
    {
        var staffs = await _staffService.Get();
        if (staffs == null)
        {
            return NotFound();
        }

        return staffs.ToList();
    }
    
    // GET: api/Staff/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Staff>> Get(int id)
    {
        var staff = await _staffService.Get(id);
        if (staff == null)
        {
            return NotFound();
        }

        return staff;
    }
    
    // PUT: api/Staff/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, StaffDto staff)
    {
        var updatedStaff = await _staffService.Update(id, staff);
        if (updatedStaff == null)
        {
            return NotFound();
        }
        
        return NoContent();
    }
    
    // POST: api/Staff
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<Staff>> Post(StaffDto staff)
    {
        await _staffService.Create(staff);
        return CreatedAtAction("Get", new { id = staff.Id }, staff);
    }
    
    // DELETE: api/Staff/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var staff = await _staffService.Get(id);
        if (staff == null)
        {
            return NotFound();
        }
        
        await _staffService.Delete(id);
        return NoContent();
    }
}