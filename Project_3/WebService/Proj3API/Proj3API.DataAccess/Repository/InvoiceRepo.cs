using Proj3API.Library;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Proj3API.Models;

namespace Proj3API.DataAccess.Repository
{
    public class InvoiceRepo : IRepository<Library.Invoice>
    {
        public Db_PegaOrdersContext Context;

        InvoiceRepo(Db_PegaOrdersContext context)
        {
            Context = context ?? throw new ArgumentNullException(nameof(context));
            Context.Database.EnsureCreated();
        }

        public bool Create(Library.Invoice obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Library.Invoice obj)
        {
            throw new NotImplementedException();
        }

        public List<Library.Invoice> Get()
        {
            throw new NotImplementedException();
        }

        public Library.Invoice GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Library.Invoice obj)
        {
            throw new NotImplementedException();
        }
    }
}
