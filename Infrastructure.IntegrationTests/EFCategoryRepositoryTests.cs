using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Infrastructure.IntegrationTests
{
    public class EFCategoryRepositoryTests
    {
        private readonly FurnitureDbContext _context;
        private readonly EfCategoryRepository _repository;

        public EFCategoryRepositoryTests()
        {
            var options = new DbContextOptionsBuilder<FurnitureDbContext>()
                .UseInMemoryDatabase(databaseName: "furniture").Options;

            _context = new FurnitureDbContext(options);
            _repository = new EfCategoryRepository(_context);

        }

        [Fact]
        public void ShouldCreateCategory()
        {
            var category = new Category
            {
                Name = "test",
                Description = "test"
            };

            _repository.Create(category);

            Assert.NotEqual(default, category.Id);

        }

        [Fact]
        public void ShouldGetCategoryById()
        {
            var category = new Category
            {
                Name = "test",
                Description = "test"
            };

            _context.Add(category);
            _context.SaveChanges();

           var savedCategory = _repository.GetById(category.Id);

            Assert.NotNull(savedCategory);
            Assert.Equal(savedCategory.Id, category.Id);

        }
    }
}