using System;
using System.Collections.Generic;
using System.Linq;
using valentines.Models;
using valentines.Repositories;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace valentines.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandiesController : ControllerBase
    {
        private readonly CandiesRepository _cr;
        public CandiesController(CandiesRepository cr)
        {
            _cr = cr;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Candy>> Get()
        {
            IEnumerable<Candy> results = _cr.Get();
            if (results == null)
            {
                return BadRequest();
            }
            return Ok(results);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}