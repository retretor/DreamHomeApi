using Microsoft.AspNetCore.Mvc;
using DreamHomeApi.DTOs;
using DreamHomeApi.Models;
using DreamHomeApi.Services;

namespace DreamHomeApi.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class ClientController : ControllerBase
{
    private readonly ClientService _clientService;

    public ClientController(ClientService clientService)
    {
        _clientService = clientService;
    }

    // GET: api/Client
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Client>>> Get()
    {
        var clients = await _clientService.Get();
        if (clients == null)
        {
            return NotFound();
        }

        return clients.ToList();
    }

    // GET: api/Client/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Client>> Get(int id)
    {
        var branch = await _clientService.Get(id);
        if (branch == null)
        {
            return NotFound();
        }

        return branch;
    }

    // PUT: api/Client/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, ClientDto client)
    {
        var updatedClient = await _clientService.Update(id, client);
        if (updatedClient == null)
        {
            return NotFound();
        }
        
        return NoContent();
    }

    // POST: api/Client
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<Client>> Post(ClientDto client)
    {
        var createdClient = await _clientService.Create(client);
        if (createdClient == null)
        {
            return NotFound();
        }
        
        return CreatedAtAction("Get", new { id = createdClient.Id }, createdClient);
    }

    // DELETE: api/Client/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var client = await _clientService.Get(id);
        if (client == null)
        {
            return NotFound();
        }
        
        await _clientService.Delete(id);
        return NoContent();
    }
}