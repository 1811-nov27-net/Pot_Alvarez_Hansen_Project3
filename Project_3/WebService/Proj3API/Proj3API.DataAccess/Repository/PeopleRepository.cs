using Proj3API.Library;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Proj3API.Models;

namespace Proj3API.DataAccess.Repository
{
    public class PeopleRepository : IRepository<Library.People>
    {
        public Db_PegaOrdersContext Context;

        public PeopleRepository(Db_PegaOrdersContext context)
        {
            Context = context ?? throw new ArgumentNullException(nameof(context));
            Context.Database.EnsureCreated();
        }

        public bool Create(Library.People obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Library.People obj)
        {
            throw new NotImplementedException();
        }

        public List<Library.People> Get()
        {
            throw new NotImplementedException();
        }

        public Library.People GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Library.People obj)
        {
            throw new NotImplementedException();
        }
    }
}
