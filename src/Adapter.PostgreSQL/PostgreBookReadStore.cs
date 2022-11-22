using Core.BookRead;

namespace Adapter.PostgreSQL;
public class PostgreBookReadStore : IBookReadStore
{
    public Task<bool> AddAsync(int userId, string isbn)
    {
        throw new NotImplementedException();
    }

    public Task<string> GetAsync()
    {
        return Task.FromResult("Hello world!");
    }
}