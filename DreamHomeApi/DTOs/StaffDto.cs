using DreamHomeApi.Models;

namespace DreamHomeApi.DTOs;

public record struct StaffDto(int Id, string FirstName, string LastName, string Position, Sex Sex, DateOnly DateOfBirth, float Salary, int SupervisorId, int BranchId);