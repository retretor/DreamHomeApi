using System.ComponentModel.DataAnnotations;

namespace DreamHomeApi.DTOs;

public record struct ClientDto
{
    [Microsoft.Build.Framework.Required]
    public int Id { get; init; }
        
    [Microsoft.Build.Framework.Required]
    public string FirstName { get; init; }
        
    [Microsoft.Build.Framework.Required]
    public string LastName { get; init; }

    [RegularExpression(@"0[0-9]{2}-[0-9]{3}-[0-9]{2}-[0-9]{2}")]
    public string PhoneNumber { get; init; }
        
    [Microsoft.Build.Framework.Required]
    public string PrefType { get; init; }
        
    [Range(0, float.MaxValue)]
    public float MaxRent { get; init; }
}