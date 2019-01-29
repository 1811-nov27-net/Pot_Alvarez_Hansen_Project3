using Proj3API.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Proj3API.DataAccess.Repository
{
    public interface IRepository<T>
    {
        //CRUD methods
        Task<bool> CreateAsync(T obj);
        Task<List<Library.Company>> GetAsync();
        Task<T> GetByIdAsync(int id);
        bool UpdateAsync(T obj);
        bool DeleteAsync(int id);
    }
}
