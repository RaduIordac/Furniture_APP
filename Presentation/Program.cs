// See https://aka.ms/new-console-template for more information
using Application;
using Infrastructure;

Console.WriteLine("Hello, World!");

IProduct productRepo = new InMemProductRepo();

var allProducts = productRepo.GetAllProducts();

foreach (var p in allProducts)
{
    Console.WriteLine($" - {p.Name}- ");
}
