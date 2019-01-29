using Proj3API.Library;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Proj3API.Models;

namespace Proj3API.DataAccess.Repository
{
    public class OrderDetailRepository : IRepository<Library.OrderDetail>
    {
        public Db_PegaOrdersContext Context;

        public OrderDetailRepository(Db_PegaOrdersContext context)
        {
            Context = Context ?? throw new ArgumentNullException(nameof(context));
            Context.Database.EnsureCreated();
        }

        public bool Create(Library.OrderDetail obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Library.OrderDetail obj)
        {
            throw new NotImplementedException();
        }

        public List<Library.OrderDetail> Get()
        {
            throw new NotImplementedException();
        }

        public Library.OrderDetail GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Library.OrderDetail obj)
        {
            throw new NotImplementedException();
        }
    }
}
