using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DreamHomeApi.Models;

[PrimaryKey("Id")]
public class Viewing
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    public int PropertyId { get; set; }
    
    public int ClientId { get; set; }
    
    public DateOnly ViewDate { get; set; }
    
    public Viewing() { }
    
    public Viewing(int id, int propertyId, int clientId, DateOnly viewDate)
    {
        Id = id;
        PropertyId = propertyId;
        ClientId = clientId;
        ViewDate = viewDate;
    }
    
    public void Update(int propertyId, int clientId, DateOnly viewDate)
    {
        PropertyId = propertyId;
        ClientId = clientId;
        ViewDate = viewDate;
    }
}