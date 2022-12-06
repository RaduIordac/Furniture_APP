// See https://aka.ms/new-console-template for more information
using Application;
using Application.Products.Create;
using Infrastructure;
using MediatR;
using Microsoft.Extensions.DependencyInjection;


Console.WriteLine("Hello, World!");

var container = new ServiceCollection()
    .AddScoped<IProductRepository, EfProductRepository>()
    .AddMediatR(typeof(ApplicationAssembly))
    .AddScoped<FurnitureDbContext>()
    .BuildServiceProvider();

// var command = container.GetRequiredService<CreateProductCommandHandler>();
// new  CreateProductCommandHandler(new InMemProductRepo())
var mediatopr = container.GetRequiredService<IMediator>();

await mediatopr.Send(new CreateProductCommand
{
    Name = "Giggel",
    Price = 100,
});



IProductRepository productRepo = container.GetRequiredService<IProductRepository>();

var allProducts = productRepo.GetAll();

foreach (var p in allProducts)
{
    Console.WriteLine($" - {p.Name}- {p.Id} -- {p.Price} - {p.Parts}");
}
