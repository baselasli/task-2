using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_Traning.models
{
   public interface IGenRepo<T> where T:class,IBM
    {

        Task Add(T t);
        Task DeleteByID(int id);
        Task<IEnumerable<T>> GetAll();
        Task<T> GetByID(int id);
    }
}
