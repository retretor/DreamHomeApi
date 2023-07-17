using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DreamHomeApi.Models;

[PrimaryKey("Id")]
public class Branch
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    public string City { get; set; }

    public string Street { get; set; }
    
    public string PostCode { get; set; }

    public Branch() { }
    public Branch(int id, string city, string street, string postCode)
    {
        Id = id;
        City = city;
        Street = street;
        PostCode = postCode;
    }

    public void Update(string city, string street, string postCode)
    {
        City = city;
        Street = street;
        PostCode = postCode;
    }
}