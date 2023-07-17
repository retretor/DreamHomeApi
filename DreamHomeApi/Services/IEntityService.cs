namespace DreamHomeApi.Services;

public interface IEntityService<T, in TDto> where T : class where TDto : struct
{
    Task<IEnumerable<T>?> Get();
    Task<T?> Get(int id);
    Task<T?> Update(int id, TDto dto);
    Task<T?> Create(TDto dto);
    Task Delete(int id);
}