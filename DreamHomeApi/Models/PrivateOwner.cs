using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DreamHomeApi.Models;

[PrimaryKey("Id")]
public class PrivateOwner
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    public string FirstName { get; set; }
    
    public string LastName { get; set; }
    
    public string Address { get; set; }
    
    [RegularExpression(@"0[0-9]{2}-[0-9]{3}-[0-9]{2}-[0-9]{2}")]
    public string PhoneNumber { get; set; }

    public PrivateOwner() { }

    public PrivateOwner(int id, string firstName, string lastName, string address, string phoneNumber)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Address = address;
        PhoneNumber = phoneNumber;
    }
    
    public void Update(string firstName, string lastName, string address, string phoneNumber)
    {
        FirstName = firstName;
        LastName = lastName;
        Address = address;
        PhoneNumber = phoneNumber;
    }
}