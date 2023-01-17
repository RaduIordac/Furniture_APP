using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAllUsers();

        User GetById(int Id);

        int Create(User user);

        int Update(User user);

        int Delete(User user);

    }
}
