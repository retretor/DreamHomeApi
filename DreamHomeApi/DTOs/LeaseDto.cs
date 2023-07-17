namespace DreamHomeApi.DTOs;

public record struct LeaseDto(int Id, int PropertyId, int ClientId, float Rent, string PaymentMethod, float Deposit, float Paid, DateOnly StartDate, DateOnly EndDate, int Duration);