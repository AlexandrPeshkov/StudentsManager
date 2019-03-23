using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DAL.Data.EntityFramework;
using DAL.Data.EntityFramework.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web.Api.Controllers
{
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        ApplicationDbContext dbContextFactory;
        public StudentsController(ApplicationDbContext dbContextFactory)
        {
            this.dbContextFactory = dbContextFactory;
        }

        // GET: api/<controller>
        [HttpGet]
        public JsonResult Get()
        {
            return new JsonResult(dbContextFactory.Students.Select(s => s));
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
