using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DreamHomeApi.Models;

[PrimaryKey("Id")]
public class PropertyForRent
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public string City { get; set; }

    public string Street { get; set; }

    public string PostCode { get; set; }

    public string Type { get; set; }

    public int Rooms { get; set; }

    public float Rent { get; set; }

    public int PropertyOwnerId { get; set; }

    public int OverseerId { get; set; }

    public int BranchId { get; set; }

    public PropertyForRent()
    {
    }

    public PropertyForRent(int id, string city, string street, string postCode, string type, int rooms, float rent,
        int propertyOwnerId, int overseerId, int branchId)
    {
        Id = id;
        City = city;
        Street = street;
        PostCode = postCode;
        Type = type;
        Rooms = rooms;
        Rent = rent;
        PropertyOwnerId = propertyOwnerId;
        OverseerId = overseerId;
        BranchId = branchId;
    }

    public void Update(string city, string street, string postCode, string type, int rooms, float rent,
        int propertyOwnerId, int overseerId, int branchId)
    {
        City = city;
        Street = street;
        PostCode = postCode;
        Type = type;
        Rooms = rooms;
        Rent = rent;
        PropertyOwnerId = propertyOwnerId;
        OverseerId = overseerId;
        BranchId = branchId;
    }
}