using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DreamHomeApi.Models;

[PrimaryKey("Id")]
public class Lease
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    public int PropertyId { get; set; }
    
    public int ClientId { get; set; }
    
    public float Rent { get; set; }
    
    public string PaymentMethod { get; set; }
    
    public float Deposit { get; set; }
    
    public float Paid { get; set; }
    
    public DateOnly StartDate { get; set; }
    
    public DateOnly EndDate { get; set; }
    
    public int Duration { get; set; }
    
    public Lease() {}
    
    public Lease(int id, int propertyId, int clientId, float rent, string paymentMethod, float deposit, float paid, DateOnly startDate, DateOnly endDate, int duration)
    {
        Id = id;
        PropertyId = propertyId;
        ClientId = clientId;
        Rent = rent;
        PaymentMethod = paymentMethod;
        Deposit = deposit;
        Paid = paid;
        StartDate = startDate;
        EndDate = endDate;
        Duration = duration;
    }
    
    public void Update(int propertyId, int clientId, float rent, string paymentMethod, float deposit, float paid, DateOnly startDate, DateOnly endDate, int duration)
    {
        PropertyId = propertyId;
        ClientId = clientId;
        Rent = rent;
        PaymentMethod = paymentMethod;
        Deposit = deposit;
        Paid = paid;
        StartDate = startDate;
        EndDate = endDate;
        Duration = duration;
    }
}