namespace Core.BookRead;
public interface IAddBookRead
{
    Task<bool> AddReadAsync(int userId, string isbn);
}
