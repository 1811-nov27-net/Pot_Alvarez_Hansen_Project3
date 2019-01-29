using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Proj3API.Models;
using System.Threading.Tasks;
using System.Linq;
using Proj3API.Library;

namespace Proj3API.DataAccess.Repository
{
    public class CompanyRepo : IRepository<Library.Company>
    {
        public Db_PegaOrdersContext Context;
        public CompanyRepo(Db_PegaOrdersContext context)
        {
            Context = context ?? throw new ArgumentNullException(nameof(context));
            Context.Database.EnsureCreated();
        }

        public async Task<bool> CreateAsync(Library.Company obj)
        {
            bool returnValue = true;
            try
            {
                var dbCompany = Mapper.Map(obj);
                await Context.AddAsync(obj);
                await Context.SaveChangesAsync();
                obj.Id = dbCompany.Id; // takes advantage of "IDENTITY" constraint from SQL Server Database to assign new ID
                return returnValue;
            }
            catch (Exception)
            {
                returnValue = false;
                return returnValue;
            }
        }

        public bool DeleteAsync(int id)
        {
            bool returnValue = true;
            try
            {
                Context.Company.Remove(Context.Company.Where(c => c.Id == id).FirstOrDefault());
                return returnValue;
            }
            catch (Exception)
            {
                returnValue = false;
                return returnValue;
            }
            
        }

        public async Task<List<Library.Company>> GetAsync()
        {
            IEnumerable<Models.Company> dbCompanyIEnum = await Context.Company.ToListAsync();
            IEnumerable<Library.Company> libCompanyIEnum = Mapper.Map(dbCompanyIEnum);
            return libCompanyIEnum.ToList();
        }

        public async Task<Library.Company> GetByIdAsync(int id)
        {
            Models.Company dbCompany = await Context.Company.Where(c => c.Id == id).FirstOrDefaultAsync();
            Library.Company libCompany = Mapper.Map(dbCompany);
            return libCompany;
        }

        public bool UpdateAsync(Library.Company obj)
        {
            bool returnValue = true;
            try
            {
                Models.Company dbCompany = Mapper.Map(obj);
                if (Context.Company.Find(obj.Id) != null);
                {
                    Context.Entry(Context.Company.FindAsync(obj.Id)).CurrentValues.SetValues(dbCompany);
                    Context.SaveChanges();
                    return returnValue;
                }
            }
            catch (Exception)
            {
                returnValue = false;
                return returnValue;
            }
        }
    }
}
