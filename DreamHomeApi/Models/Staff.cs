using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DreamHomeApi.Models;

[PrimaryKey("Id")]
public class Staff
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    public string FirstName { get; set; }
    
    public string LastName { get; set; }

    public string Position { get; set; }

    public Sex Sex { get; set; }
    
    public DateOnly DateOfBirth { get; set; }
    
    public float Salary { get; set; }

    public int SupervisorId { get; set; }
    
    public int BranchId { get; set; }

    public Staff()
    {
        SupervisorId = -1;
        BranchId = -1;
    }

    public Staff(int id, string firstName, string lastName, string position, Sex sex, DateOnly dateOfBirth,
        float salary, int supervisorId, int branchId)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Position = position;
        Sex = sex;
        DateOfBirth = dateOfBirth;
        Salary = salary;
        SupervisorId = supervisorId;
        BranchId = branchId;
    }

    public void Update(string firstName, string lastName, string position, Sex sex, DateOnly dateOfBirth,
        float salary, int supervisorId, int branchId)
    {
        FirstName = firstName;
        LastName = lastName;
        Position = position;
        Sex = sex;
        DateOfBirth = dateOfBirth;
        Salary = salary;
        SupervisorId = supervisorId;
        BranchId = branchId;
    }
}

public enum Sex
{
    Male,
    Female
}