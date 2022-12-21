using Domain;

namespace Application.Categories
{
    public class CategoryDto
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public ICollection<Product>? Products { get; set; }

        public ICollection<Part>? Parts { get; set; }
    }
}