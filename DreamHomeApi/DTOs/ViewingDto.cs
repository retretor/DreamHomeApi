namespace DreamHomeApi.DTOs;

public record struct ViewingDto(int Id, int PropertyId, int ClientId, DateOnly ViewDate);