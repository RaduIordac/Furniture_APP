using Application;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class EFUserRepository : IUserRepository
    {
        public readonly FurnitureDbContext _dbContext;

        public EFUserRepository(FurnitureDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<User> GetAllUsers()
        {
            return _dbContext.Users.ToList();
            }

        public User GetById(int Id)
        {
            return _dbContext.Users.FirstOrDefault(x => x.Id == Id);
        }

        public int Create(User user)
        {
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
            return user.Id;
        }
        public int Update(User user)
        {
            _dbContext.Users.Update(user);
            _dbContext.SaveChanges();
            return user.Id;
        }

        public int Delete(User user)
        {
            //_dbContext.Users.ExecuteDelete(user);
            //_dbContext.SaveChanges();
            //return user.Id;
            return 0;
        }
                              
                
    }
}
