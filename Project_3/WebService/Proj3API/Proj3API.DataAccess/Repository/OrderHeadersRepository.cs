using Proj3API.Library;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Proj3API.Models;

namespace Proj3API.DataAccess.Repository
{
    public class OrderHeadersRepository : IRepository<Library.OrderHeaders>
    {
        public Db_PegaOrdersContext Context;

        public OrderHeadersRepository(Db_PegaOrdersContext context)
        {
            Context = context ?? throw new ArgumentNullException(nameof(context));
            Context.Database.EnsureCreated();
        }

        public bool Create(Library.OrderHeaders obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Library.OrderHeaders obj)
        {
            throw new NotImplementedException();
        }

        public List<Library.OrderHeaders> Get()
        {
            throw new NotImplementedException();
        }

        public Library.OrderHeaders GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Library.OrderHeaders obj)
        {
            throw new NotImplementedException();
        }
    }
}
