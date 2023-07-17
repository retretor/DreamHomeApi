using Microsoft.AspNetCore.Mvc;
using DreamHomeApi.DTOs;
using DreamHomeApi.Models;
using DreamHomeApi.Services;

namespace DreamHomeApi.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class BranchController : ControllerBase
{
    private readonly BranchService _branchService;

    public BranchController(BranchService branchService)
    {
        _branchService = branchService;
    }

    // GET: api/Branch
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Branch>>> Get()
    {
        var branches = await _branchService.Get();
        if (branches == null)
        {
            return NotFound();
        }

        return branches.ToList();
    }

    // GET: api/Branch/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Branch>> Get(int id)
    {
        var branch = await _branchService.Get(id);
        if (branch == null)
        {
            return NotFound();
        }

        return branch;
    }

    // PUT: api/Branch/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, BranchDto branch)
    {
        var updatedBranch = await _branchService.Update(id, branch);
        if (updatedBranch == null)
        {
            return NotFound();
        }
        
        return NoContent();
    }

    // POST: api/Branch
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<Branch>> Post(BranchDto branch)
    {
        var createdBranch = await _branchService.Create(branch);
        if (createdBranch == null)
        {
            return NotFound();
        }
        
        return CreatedAtAction("Get", new { id = createdBranch.Id }, createdBranch);
    }

    // DELETE: api/Branch/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var branch = await _branchService.Get(id);
        if (branch == null)
        {
            return NotFound();
        }
        
        await _branchService.Delete(id);
        return NoContent();
    }
}