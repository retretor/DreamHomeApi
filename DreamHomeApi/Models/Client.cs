using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DreamHomeApi.Models;

[PrimaryKey("Id")]
public class Client
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    public string FirstName { get; set; }
    
    public string LastName { get; set; }

    [RegularExpression(@"0[0-9]{2}-[0-9]{3}-[0-9]{2}-[0-9]{2}")]
    public string PhoneNumber { get; set; }
    
    public string PrefType { get; set; }
    
    [Range(0, float.MaxValue)]
    public float MaxRent { get; set; }

    public Client() {}
    
    public Client(int id, string firstName, string lastName, string phoneNumber, string prefType, float maxRent)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        PhoneNumber = phoneNumber;
        PrefType = prefType;
        MaxRent = maxRent;
    }
    
    public void Update(string firstName, string lastName, string phoneNumber, string prefType, float maxRent)
    {
        FirstName = firstName;
        LastName = lastName;
        PhoneNumber = phoneNumber;
        PrefType = prefType;
        MaxRent = maxRent;
    }
}