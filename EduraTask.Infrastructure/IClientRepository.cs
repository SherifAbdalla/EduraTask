using EduraTask.Domain;

namespace EduraTask.Infrastructure;

public interface IClientRepository
{
    Task<IQueryable<ClientResult>> Get();
}
