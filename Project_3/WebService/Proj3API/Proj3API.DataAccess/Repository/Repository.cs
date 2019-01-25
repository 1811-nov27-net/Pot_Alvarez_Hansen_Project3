using Proj3API.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proj3API.DataAccess.Repository
{
    public class Repository : IRepository
    {
        private Db_PegaOrdersContext _db;

        public Repository(Db_PegaOrdersContext db)
        {
            db = _db ?? throw new ArgumentNullException(nameof(db));
        }
    }
}
