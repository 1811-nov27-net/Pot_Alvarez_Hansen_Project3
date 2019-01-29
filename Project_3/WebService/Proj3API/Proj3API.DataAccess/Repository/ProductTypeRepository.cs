using Proj3API.Library;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Proj3API.Models;

namespace Proj3API.DataAccess.Repository
{
    public class ProductTypeRepository : IRepository<Library.ProductType>
    {
        public Db_PegaOrdersContext Context;

        public ProductTypeRepository(Db_PegaOrdersContext context)
        {
            Context = context ?? throw new ArgumentNullException(nameof(context));
            Context.Database.EnsureCreated();
        }

        public bool Create(Library.ProductType obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Library.ProductType obj)
        {
            throw new NotImplementedException();
        }

        public List<Library.ProductType> Get()
        {
            throw new NotImplementedException();
        }

        public Library.ProductType GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Library.ProductType obj)
        {
            throw new NotImplementedException();
        }
    }
}
