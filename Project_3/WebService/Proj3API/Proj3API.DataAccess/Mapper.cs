using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proj3API.DataAccess
{
    public class Mapper
    {
        // mapping from Models.Company to Library.Company
        public static Library.Company Map(Models.Company company) => new Library.Company
        {
            Id = company.Id,
            CompanyName = company.CompanyName
        };
        public static IEnumerable<Library.Company> Map(IEnumerable<Models.Company> company) => company.Select(Map);

        // mapping from Library.Company to Models.Company
        public static Models.Company Map(Library.Company company) => new Models.Company
        {
            Id = company.Id,
            CompanyName = company.CompanyName
        };
        public static IEnumerable<Models.Company> Map(IEnumerable<Library.Company> company) => company.Select(Map);
    }
}
