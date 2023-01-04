using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Xunit.Sdk;

namespace Infrastructure.Tests
{
    [TestClass()]
    public class EfCategoryRepositoryTests
    {
        [TestMethod()]
        public void EfCategoryRepositoryTest()
        {
            var mockDBSet = new Mock<DbSet<Category>>();

            var mockDbContext = new Mock<FurnitureDbContext>();
            mockDbContext.Setup(m => m.Categories).Returns(mockDBSet.Object);

            var repository = new EfCategoryRepository(mockDbContext.Object);
            repository.Create(new Category());

            Assert.Fail();
        }

        [TestMethod()]
        public void GetAllCategoriesTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetByIdTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CreateTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void UpdateTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteTest()
        {
            Assert.Fail();
        }
    }
}