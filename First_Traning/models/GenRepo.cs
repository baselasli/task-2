using First_Traning.Controllers.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_Traning.models
{
    public class GenRepo<T> : IGenRepo<T> where T : class, IBM
    {
        private readonly AppDbContext dbContext;

        public GenRepo(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task Add(T user)
        {
            await dbContext.Set<T>().AddAsync(user);
            await dbContext.SaveChangesAsync();
        }

        public async Task DeleteByID(int id)
        {
            var filteredUsers = await dbContext.Set<T>().FirstOrDefaultAsync(T => T.Id.Equals(id));
            if (filteredUsers != null)
                dbContext.Set<T>().Remove(filteredUsers);
            await dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await dbContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByID(int id)
        {
            return await dbContext.Set<T>().FirstOrDefaultAsync(user => user.Id.Equals(id));

        }




    }
}
