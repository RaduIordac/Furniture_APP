using Infrastructure;

namespace FurnitureWebAPI
{
    public class Seed
    {
        private readonly FurnitureDbContext _dataContext;
        public Seed(FurnitureDbContext context)
        {
            _dataContext = context;
        }

    }
}
