namespace Core.BookRead;
public interface IBookReadStore
{
    Task<bool> AddAsync(int userId, string isbn);
    Task<string> GetAsync();

}