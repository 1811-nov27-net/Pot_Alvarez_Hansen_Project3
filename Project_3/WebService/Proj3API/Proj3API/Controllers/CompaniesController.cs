//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Proj3API.DataAccess;
//using Proj3API.DataAccess.Repository;

//namespace Proj3API.App.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class CompaniesController : ControllerBase
//    {
//        public IRepository<Library.Company> Repo;

//        public CompaniesController(IRepository<Library.Company> repo)
//        {
//            Repo = repo;
//        }

//        // GET: api/Company
//        [HttpGet]
//        public Task<ActionResult<IEnumerable<Library.Company>>> Get()
//        {
//            try
//            {
//                var libCompanyIEnum = Mapper.Map(Repo.GetAsync());
//            }
//            catch (Exception)
//            {
//                return StatusCode(500);
//            }
//        }

//        // GET: api/Company/{id}
//        [HttpGet("{id}", Name = "GetById")]
//        public ActionResult<Library.Company> GetById(int id)
//        {
//            try
//            {
//                return Repo.GetById(id);
//            }
//            catch (Exception)
//            {
//                return StatusCode(500);
//            }
//        }

//        // POST: api/Company
//        [HttpPost]
//        public ActionResult Post(Library.Company company)
//        {
//            try
//            {
//                return Repo.Create(company);
//            }
//        }

//    }
//}