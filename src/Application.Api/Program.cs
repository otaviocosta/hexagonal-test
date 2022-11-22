using Adapter.Api;
using Adapter.Kafka;
using Adapter.PostgreSQL;
using Core.BookRead;
using Microsoft.Extensions.DependencyInjection;

var api = new AdapterApi(args, options =>
{
    //options.AddScoped<IAddBookRead, AddBookRead>();
    options.AddScoped<IBookReadStore, PostgreBookReadStore>();
    options.AddScoped<IBookReadPublisher, KafkaBookReadPublisher>();
}
);

await api.RunAsync();