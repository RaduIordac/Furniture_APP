using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Application
{
   public interface IPartRepository
        {
            IEnumerable<Part> GetAllParts();
            Part GetPart(int id);
            int Create(Part part);
            int Update(Part part);
            int Delete(Part part);

    }
}

