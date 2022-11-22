namespace Core.BookRead;

public interface IBookReadPublisher
{
    Task<bool> PublishAsync(int userId, string isbn);
}