using Proj3API.Library;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Proj3API.Models;

namespace Proj3API.DataAccess.Repository
{
    public class ProductsRepository : IRepository<Library.Products>
    {
        public Db_PegaOrdersContext Context;

        public ProductsRepository(Db_PegaOrdersContext context)
        {
            Context = context ?? throw new ArgumentNullException(nameof(context));
            Context.Database.EnsureCreated();
        }

        public bool Create(Library.Products obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Library.Products obj)
        {
            throw new NotImplementedException();
        }

        public List<Library.Products> Get()
        {
            throw new NotImplementedException();
        }

        public Library.Products GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Library.Products obj)
        {
            throw new NotImplementedException();
        }
    }
}
