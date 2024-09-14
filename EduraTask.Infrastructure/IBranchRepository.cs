using EduraTask.Domain;

namespace EduraTask.Infrastructure;

public interface IBranchRepository
{
    Task<IQueryable<Branch>> Get();
}
