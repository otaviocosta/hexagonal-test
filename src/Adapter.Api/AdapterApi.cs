using Core.BookRead;
namespace Adapter.Api;
public class AdapterApi
{
    WebApplication _app;

    public AdapterApi(string[] args, Action<IServiceCollection> options)
    {
        var _builder = WebApplication.CreateBuilder(args);
        options.Invoke(_builder.Services);
        _builder.Services.AddControllers();
        _builder.Services.AddEndpointsApiExplorer();
        _builder.Services.AddSwaggerGen();
        _app = _builder.Build();
        if (_app.Environment.IsDevelopment())
        {
            _app.UseSwagger();
            _app.UseSwaggerUI();
        }
        _app.UseHttpsRedirection();
        _app.UseAuthorization();
        _app.MapControllers();
        _app.MapPost("/reads", (IAddBookRead read, string isbn) => read.AddReadAsync(1, isbn));
        _app.MapGet("/reads/get", (IBookReadStore read) => read.GetAsync());
    }

    public Task RunAsync()
    {
        return _app.RunAsync();
    }
}