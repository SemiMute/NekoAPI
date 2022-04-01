using NekoQOLWebAPI.Entities;

namespace NekoQOLWebAPI.Repositories;

public interface IHypixelPlayerRespository
{

    Task<IEnumerable<HypixelPlayer>> Get();
    Task<HypixelPlayer?> GetById(Guid id);

    Task<HypixelPlayer> Create(HypixelPlayer player);

    Task Update(HypixelPlayer player);

    Task Delete(Guid id);
}
