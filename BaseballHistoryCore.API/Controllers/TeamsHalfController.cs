using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BaseballHistoryCore.API.Controllers
{
    [Produces("application/json")]
    [Route("api/TeamsHalf")]
    public class TeamsHalfController : Controller
    {
        // GET: api/TeamsHalf
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/TeamsHalf/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
    }
}