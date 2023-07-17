using DreamHomeApi.Data;

namespace DreamHomeApi.Services;

public class EntityService<T, TDto> : IEntityService<T, TDto> where T : class where TDto : struct
{
    private readonly DbRepository _repository = new DbRepository();

    public async Task<IEnumerable<T>?> Get()
    {
        var entities = await _repository.GetAllAsync<T>();
        return entities;
    }

    public async Task<T?> Get(int id)
    {
        var entity = await _repository.GetAsync<T>(id);
        return entity;
    }

    public async Task<T?> Update(int id, TDto dto)
    {
        var updatedEntity = await _repository.UpdateAsync<T>(id, dto);
        return updatedEntity;
    }

    public async Task<T?> Create(TDto dto)
    {
        var createdEntity = await _repository.CreateAsync<T>(dto);
        return createdEntity;
    }

    public async Task Delete(int id)
    {
        await _repository.DeleteAsync<T>(id);
    }
}