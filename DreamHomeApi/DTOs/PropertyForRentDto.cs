namespace DreamHomeApi.DTOs;

public record struct PropertyForRentDto(int Id, string City, string Street, string PostCode, string Type, int Rooms, float Rent, int PropertyOwnerId, int OverseerId, int BranchId);