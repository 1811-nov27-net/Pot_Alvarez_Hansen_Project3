using Proj3API.Library;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Proj3API.Models;

namespace Proj3API.DataAccess.Repository
{
    public class LogsRepository : IRepository<Library.Logs>
    {
        public Db_PegaOrdersContext Context;

        public LogsRepository(Db_PegaOrdersContext context)
        {
            Context = context ?? throw new ArgumentNullException(nameof(context));
            Context.Database.EnsureCreated();
        }

        public bool Create(Library.Logs obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Library.Logs obj)
        {
            throw new NotImplementedException();
        }

        public List<Library.Logs> Get()
        {
            throw new NotImplementedException();
        }

        public Library.Logs GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Library.Logs obj)
        {
            throw new NotImplementedException();
        }
    }
}
