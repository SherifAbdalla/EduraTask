using EduraTask.Domain;

namespace EduraTask.Infrastructure;

public interface IServiceRepository
{
    Task<IQueryable<Service>> Get();
}
