using Application;
using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class EfPartRepository : IPartRepository
    {
        public readonly FurnitureDbContext _dbContext;

        public EfPartRepository(FurnitureDbContext dbContext)
        {
            _dbContext = dbContext;
        }
             
        public IEnumerable<Part> GetAllParts()
        {
            return _dbContext.Parts.ToList();
        }

        public Part GetPart(int Id)
        {
            return _dbContext.Parts.FirstOrDefault(x => x.Id == Id);
        }

        public int Create(Part part)
        {
            _dbContext.Parts.Add(part);
            _dbContext.SaveChanges();
            return part.Id;
        }

        public int Update(Part part)
        {
            _dbContext.Parts.Update(part);
            _dbContext.SaveChanges();
            return part.Id;
        }

        public int Delete(Part part)
        {
            //_dbContext.Parts.ExecuteDelete(part);
            //_dbContext.SaveChanges();
            //return part.Id;
            return 0;
        }
    }
}
